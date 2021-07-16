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
    public partial class MLS1 
    {
        public MLS1()
        {
          this.ObjType= string.Empty;
          this.ObjCode= string.Empty;
          this.ObjName= string.Empty;
          this.E_Mail= string.Empty;
          this.PortNum= string.Empty;
          this.Fax= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PortNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
    }
}