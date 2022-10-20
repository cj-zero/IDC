using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Core
{
    public class DBContextFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DBContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public DbContext GetDbContext<T>() where T : class
        {
            if (StaticCommon.ContextDir.TryGetValue(typeof(T), out Type contextType))
            {
                return (DbContext)_serviceProvider.CreateScope().ServiceProvider.GetRequiredService(contextType);
            }
            var dbContexts = GetSubClass(typeof(DbContext));
            foreach (var dbContext in dbContexts)
            {
                foreach (var property in dbContext.GetProperties())
                {
                    if (property.PropertyType.Equals(typeof(DbSet<T>)))
                    {
                        var dbct = (DbContext)_serviceProvider.CreateScope().ServiceProvider.GetRequiredService(dbContext);
                        StaticCommon.ContextDir.TryAdd(typeof(T), dbContext);
                        return dbct;
                    }
                }
            }
            return null;
        }
        public static IList<Type> GetSubClass(Type baseType)
        {
            var subTypeQuery = from t in Assembly.GetCallingAssembly().GetTypes()
                               where baseType.Equals(t.BaseType)
                               select t;
            return subTypeQuery.ToList();
        }
    }
}
