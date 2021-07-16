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
    public partial class VLG1 
    {
        public VLG1()
        {
          this.FromSysDat= DateTime.Now;
          this.ToSysDate= DateTime.Now;
          this.StrFld= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromSysDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FromDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FromDocTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToSysDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CalRecOINM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastCalcTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumTranVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumFld { get; set; }
    }
}