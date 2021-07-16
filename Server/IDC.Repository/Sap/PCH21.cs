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
    public partial class PCH21 
    {
        public PCH21()
        {
          this.ObjectType= string.Empty;
          this.ExtDocNum= string.Empty;
          this.RefObjType= string.Empty;
          this.AccessKey= string.Empty;
          this.IssueDate= DateTime.Now;
          this.IssuerCNPJ= string.Empty;
          this.IssuerCode= string.Empty;
          this.Model= string.Empty;
          this.Series= string.Empty;
          this.RefAccKey= string.Empty;
          this.SubSeries= string.Empty;
          this.Remark= string.Empty;
          this.LinkRefTyp= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefDocEntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccessKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? IssueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IssuerCNPJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IssuerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefAccKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RefAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkRefTyp { get; set; }
    }
}