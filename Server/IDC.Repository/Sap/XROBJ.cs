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
    public partial class XROBJ 
    {
        public XROBJ()
        {
          this.Name= string.Empty;
          this.Descriptio= string.Empty;
          this.Creator= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ModifyDate= DateTime.Now;
          this.XmlId= string.Empty;
          this.XlsId= string.Empty;
          this.VariablesI= string.Empty;
          this.Reference= string.Empty;
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
        public string Descriptio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string XmlId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string XlsId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VariablesI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefType { get; set; }
    }
}