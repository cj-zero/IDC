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
    public partial class IVLG 
    {
        public IVLG()
        {
          this.DestDBName= string.Empty;
          this.DestDBPath= string.Empty;
          this.FromSysDat= DateTime.Now;
          this.ToSysDate= DateTime.Now;
          this.CustDbUpd= string.Empty;
          this.HistTblCrt= string.Empty;
          this.SuccRecalc= string.Empty;
          this.Comment= string.Empty;
          this.EnblFromTo= string.Empty;
          this.StrFld= string.Empty;
          this.LoadCust= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UtilVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? B1Ver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcDBVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DestDBName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DestDBPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FromDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromSysDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToSysDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustDbUpd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HistTblCrt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SuccRecalc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnblFromTo { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LoadCust { get; set; }
    }
}