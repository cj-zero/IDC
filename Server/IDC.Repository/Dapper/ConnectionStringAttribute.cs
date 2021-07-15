using System;
using System.Collections.Generic;
using System.Text;

namespace IDC.Repository.Dapper
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class ConnectionStringAttribute : Attribute
    {
        public ConnectionStringAttribute(string ConnectionStringName,string ConnectionReadStringName=null,DatabaseType DbType= DatabaseType.MySql)
        {
            this.ConnectionStringName = ConnectionStringName;
            this.ConnectionReadStringName = ConnectionReadStringName;
            this.DbType = DbType;
        }

        public string ConnectionStringName { get; set; }
        public string ConnectionReadStringName { get; set; }
        public DatabaseType DbType { get; set; }
    }
}
