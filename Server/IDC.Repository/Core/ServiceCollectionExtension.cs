using AutoMapper.Configuration;
using IDC.Repository.AutoMapper;
using IDC.Repository.Dapper;
using IDC.Repository.EFDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Core
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services)
        {
            services.AddAutoMapper();
            InitDbContextDir();
            AddDbContext<Nsap4NwcaliDbContext>(services);
            AddDbContext<NewareMobileDbContext>(services);
            AddDbContext<Nsap4MaterialDbContext>(services);
            AddDbContext<NewarePassport2DbContext>(services);

            services.AddSingleton<DBContextFactory>();
            return services;
        }
        private static void AddDbContext<T>(IServiceCollection services) where T : DbContext
        {
            var configuration = services.BuildServiceProvider().GetRequiredService<Microsoft.Extensions.Configuration.IConfiguration>();
            string connectionString = "";
            var connectionStringName = typeof(T).GetCustomAttributeValue<DbConnectionStringAttribute, string>(a => a.ConnectionStringName);
            var contextDbType = typeof(T).GetCustomAttributeValue<DbConnectionStringAttribute, string>(a => a.DbType);

            if (string.IsNullOrWhiteSpace(connectionStringName))
            {
                connectionString = typeof(T).GetCustomAttributeValue<DbConnectionStringAttribute, string>(a => a.ConnectionString);
            }
            else
            {
                connectionString = configuration.GetConnectionString(connectionStringName);
            }

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                string dbType;
                if (!string.IsNullOrWhiteSpace(contextDbType))
                {
                    dbType = contextDbType;
                }
                else
                { 
                    //dbType = ((ConfigurationSection)configuration.GetSection("AppSetting:DbType")).Value;
                    dbType = "MySql";
                }

                if (dbType.ToLower() == "sqlserver") //sqlserver
                {
                    services.AddDbContext<T>(options =>
                        options.UseSqlServer(connectionString), ServiceLifetime.Transient);
                }
                else if (dbType.ToLower() == "mysql") //mysql
                {
                    var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

                    services.AddDbContext<T>(options =>
                        options.UseMySql(connectionString, serverVersion), ServiceLifetime.Transient);
                }
            }

        }

        private static void InitDbContextDir()
        {
            var dbContexts = DBContextFactory.GetSubClass(typeof(DbContext));
            foreach (var dbContext in dbContexts)
            {
                foreach (var property in dbContext.GetProperties())
                {
                    // || property.PropertyType.Name.Equal(typeof(DbQuery<>).Name)
                    if (property.PropertyType.Name.Equals(typeof(DbSet<>).Name))
                    {
                        StaticCommon.ContextDir.TryAdd(property.PropertyType.GenericTypeArguments[0], dbContext);
                    }
                }
            }
        }
    }
}
