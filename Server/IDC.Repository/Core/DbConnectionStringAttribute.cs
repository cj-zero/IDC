using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Core
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class DbConnectionStringAttribute : Attribute
    {
        public DbConnectionStringAttribute(string ConnectionStringName)
        {
            this.ConnectionStringName = ConnectionStringName;
        }

        public string ConnectionStringName { get; set; }
        public string ConnectionString { get; set; }

        public string DbType { get; set; }
    }
}
