using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Cache.CacheManager;
using Ocelot.Provider.Polly;
using Microsoft.Extensions.Configuration;

namespace IDC.Gateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var config = new ConfigurationBuilder().AddJsonFile("ocelot.json", optional: false, reloadOnChange: true).Build();
            services.AddOcelot(config)
                .AddCacheManager(x =>
                {
                    x.WithDictionaryHandle();
                }).AddPolly();
            //services.AddCors();

            //todo: �����ʽ ������������ķ�ʽ����������ʿ���
            var origins = Configuration.GetSection("CorsUrls").Value.Split(",");
            services.AddCors(option => option.AddPolicy("cors", policy =>
                  policy.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins(origins)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsProduction())
            {
                app.UseCors("cors");
            }
            //todo:���Կ����������������ʽ����Ҫ��Ȩ��
            else
            {
                app.UseCors(builder => builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
            }


            app.UseWebSockets();

            app.UseOcelot().Wait();
        }
    }
}