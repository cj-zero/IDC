using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using IDC.Repository.Dapper;

namespace IDC.Repository.Entities.Sap
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("SapDbContext", "SapReadDbContext", DatabaseType.SqlServer)]
    public partial class OAGM 
    {
        public OAGM()
        {
          this.XmlGen= string.Empty;
          this.XmlRet= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string XmlGen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string XmlRet { get; set; }
    }
}