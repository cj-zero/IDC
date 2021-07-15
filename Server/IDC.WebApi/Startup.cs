using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using IDC.Infrastructure.AutoMapper;
using IDC.Infrastructure.Thirdparty;
using IDC.Repository.Dapper;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using IDC.WebApi.Global;
using Newtonsoft.Json;
using IDC.WebApi.SapHandler;
using IDC.Application.SSO;

namespace IDC.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddControllersAsServices();
            //注册automapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddCors();
            //注册HttpClient
            services.AddHttpClient();
            //注册swagger
            services.AddSwaggerGen(c =>
            {
                foreach (var controller in GetControllers())
                {
                    c.SwaggerDoc(controller, new OpenApiInfo
                    {
                        Version = controller,
                        Title = " IDC API",
                        Description = "By Neware-R12"
                    });
                }
                // 获取xml文件名
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // 获取xml文件路径
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // 添加控制器层注释，true表示显示控制器注释
                c.IncludeXmlComments(xmlPath, true);
                //注入swagger请求头
                c.OperationFilter<GlobalAuthorizationFilter>();
            }).AddScoped<SwaggerGenerator>();//注入SwaggerGenerator,后面可以直接使用这个方法
            //redis缓存
            var csredis = new CSRedis.CSRedisClient(Configuration.GetSection("Redis:Default").Value);
            RedisHelper.Initialization(csredis);
            services.AddMvc(option =>
            {
                //注入全局异常处理
                option.Filters.Add(typeof(GlobalExceptionFilter));
                //接口执行前后
                option.Filters.Add(typeof(ActionFilter));
                
            }).AddNewtonsoftJson(options =>
            {
                //忽略循环引用
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //不使用驼峰样式的key
                //options.SerializerSettings.ContractResolver = new DefaultContractResolver();    
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            });
            //设置跨域
            services.AddCors();
            //设置cap和rabbitmq
            services.AddIDCCAP(Configuration);
            //services.AddSap(Configuration);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }

        private List<string> GetControllers()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var controlleractionlist = asm.GetTypes().Where(type => typeof(ControllerBase).IsAssignableFrom(type)).Select(a => a.CustomAttributes.LastOrDefault()?.NamedArguments.FirstOrDefault().TypedValue.Value.ToString()).Distinct().ToList();
            //var controlleractionlist = asm.GetTypes()
            //    .Where(type => typeof(ControllerBase).IsAssignableFrom(type))
            //    .OrderBy(x => x.Name).ToList();
            return controlleractionlist;
        }

        /// <summary>
        /// AutoFac依赖注入
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //注册操作数据库
            builder.RegisterType(typeof(RepositoryBase)).As(typeof(IRepositoryBase));
            //注册操作
            builder.RegisterType(typeof(Auth)).As(typeof(IAuth));
            //注册操作第三方Api
            builder.RegisterType(typeof(ThirdpartyHelper));
            //注册Application层
            var asm = Assembly.Load("IDC.Application");//指定dll名称的程序集集
            //var defulatAsm = Assembly.GetExecutingAssembly();//默认执行的dll
            builder.RegisterAssemblyTypes(asm) //asm, 
                .PublicOnly();//仅注册public的方法
                              //.Except()排除某个类
                              //.Where(t => t.Name.EndsWith("Service") || t.Name == "ClassA")//可以在这里写一些过滤类名规则
                              //.AsImplementedInterfaces();
                              //AutofacExt.InitAutofac(builder);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //swagger如发布后希望不继续使用，移入if即可
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    foreach (var controller in GetControllers())
                    {
                        c.SwaggerEndpoint($"/swagger/{controller}/swagger.json", controller);
                    }
                }
                );
            }

            //测试可以允许任意跨域，正式环境要加权限
            app.UseCors(builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(builder => builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //AutoMapperHelper扩展方法注册
            AutoMapperHelper.UseStateAutoMapper(app);
        }
    }
}
