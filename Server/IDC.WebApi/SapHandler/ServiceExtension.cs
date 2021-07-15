using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDC.WebApi.SapHandler
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddSap(this IServiceCollection services, IConfiguration configuration)
        {
            CompanySettings settings = new CompanySettings();
            configuration.GetSection("CompanySettings").Bind(settings);
            Company oCompany = new Company();
            oCompany.Server = settings.Server; //dRow[0].ToString();
            oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2016;
            oCompany.UseTrusted = false;
            oCompany.DbUserName = settings.DbUserName; //dRow[4].ToString();
            oCompany.DbPassword = settings.DbPassword; //dRow[5].ToString();
            oCompany.LicenseServer = settings.LicenseServer;//dell-t30:40000 //dRow[1].ToString();
            oCompany.UserName = settings.UserName; //dRow[2].ToString();
            oCompany.Password = settings.Password; //dRow[3].ToString();Aa789123@
            oCompany.CompanyDB = settings.CompanyDB; //dRow[6].ToString();
            oCompany.language = BoSuppLangs.ln_Chinese;
            int connecti = oCompany.Connect();
            if (connecti != 0)
            {
                int temp_int;
                string temp_string;
                oCompany.GetLastError(out temp_int, out temp_string);
                throw new Exception(temp_string);
            }
            else
            {
                //Console.WriteLine("OK"); ;//oCompany;
                services.AddSingleton(oCompany);
                //services.AddTransient<ServiceWorkOrderAPI>();
            }
            return services;
        }

        public static IServiceCollection AddIDCCAP(this IServiceCollection services, IConfiguration configuration)
        {
            CapSettings capSettings = new CapSettings();
            configuration.GetSection("CapSettings").Bind(capSettings);

            services.AddCap(config => {
                if (capSettings.UseDashboard)
                {
                    config.UseDashboard();
                }
                config.UseMySql(capSettings.MySqlConnectionString);
                config.UseRabbitMQ(options =>
                {
                    options.HostName = capSettings.RabbitMq.HostName;
                    options.Port = capSettings.RabbitMq.Prot;
                    options.UserName = capSettings.RabbitMq.UserName;
                    options.Password = capSettings.RabbitMq.Password;
                });
                config.SucceedMessageExpiredAfter = capSettings.SucceedMessageExpiredAfter;
                config.FailedRetryCount = capSettings.FailedRetryCount;
                config.FailedRetryInterval = capSettings.FailedRetryInterval;
                config.ConsumerThreadCount = capSettings.ConsumerThreadCount;
                if (!string.IsNullOrWhiteSpace(capSettings.Version))
                {
                    config.Version = capSettings.Version;
                }
            });
            return services;
        }
    }
}
