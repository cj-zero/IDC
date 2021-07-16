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
    public partial class ECM4 
    {
        public ECM4()
        {
          this.Code= string.Empty;
          this.ObjType= string.Empty;
          this.ObjXPath= string.Empty;
          this.FieldType= string.Empty;
          this.FieldXPath= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjXPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldXPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ImportFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LogInstanc { get; set; }
    }
}