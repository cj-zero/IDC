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
    public partial class OMAO 
    {
        public OMAO()
        {
          this.Name= string.Empty;
          this.URL= string.Empty;
          this.Type= string.Empty;
          this.Provider= string.Empty;
          this.ViewStyle= string.Empty;
          this.LogonMethd= string.Empty;
          this.LogonPyld= string.Empty;
          this.Enable= string.Empty;
          this.System= string.Empty;
          this.B1MobileAp= string.Empty;
          this.B1SalesApp= string.Empty;
          this.B1SrvcApp= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string URL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Provider { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogonMethd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogonPyld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Enable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string System { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string B1MobileAp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string B1SalesApp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string B1SrvcApp { get; set; }
    }
}