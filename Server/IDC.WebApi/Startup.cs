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
            //ע��automapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddCors();
            //ע��HttpClient
            services.AddHttpClient();
            //ע��swagger
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
                // ��ȡxml�ļ���
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // ��ȡxml�ļ�·��
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // ��ӿ�������ע�ͣ�true��ʾ��ʾ������ע��
                c.IncludeXmlComments(xmlPath, true);
                //ע��swagger����ͷ
                c.OperationFilter<GlobalAuthorizationFilter>();
            }).AddScoped<SwaggerGenerator>();//ע��SwaggerGenerator,�������ֱ��ʹ���������
            //redis����
            var csredis = new CSRedis.CSRedisClient(Configuration.GetSection("Redis:Default").Value);
            RedisHelper.Initialization(csredis);
            services.AddMvc(option =>
            {
                //ע��ȫ���쳣����
                option.Filters.Add(typeof(GlobalExceptionFilter));
                //�ӿ�ִ��ǰ��
                option.Filters.Add(typeof(ActionFilter));
                
            }).AddNewtonsoftJson(options =>
            {
                //����ѭ������
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //��ʹ���շ���ʽ��key
                //options.SerializerSettings.ContractResolver = new DefaultContractResolver();    
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            });
            //���ÿ���
            services.AddCors();
            //����cap��rabbitmq
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
        /// AutoFac����ע��
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //ע��������ݿ�
            builder.RegisterType(typeof(RepositoryBase)).As(typeof(IRepositoryBase));
            //ע�����
            builder.RegisterType(typeof(Auth)).As(typeof(IAuth));
            //ע�����������Api
            builder.RegisterType(typeof(ThirdpartyHelper));
            //ע��Application��
            var asm = Assembly.Load("IDC.Application");//ָ��dll���Ƶĳ��򼯼�
            //var defulatAsm = Assembly.GetExecutingAssembly();//Ĭ��ִ�е�dll
            builder.RegisterAssemblyTypes(asm) //asm, 
                .PublicOnly();//��ע��public�ķ���
                              //.Except()�ų�ĳ����
                              //.Where(t => t.Name.EndsWith("Service") || t.Name == "ClassA")//����������дһЩ������������
                              //.AsImplementedInterfaces();
                              //AutofacExt.InitAutofac(builder);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //swagger�緢����ϣ��������ʹ�ã�����if����
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

            //���Կ����������������ʽ����Ҫ��Ȩ��
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
            //AutoMapperHelper��չ����ע��
            AutoMapperHelper.UseStateAutoMapper(app);
        }
    }
}
