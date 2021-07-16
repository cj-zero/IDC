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
    public partial class OIWZ 
    {
        public OIWZ()
        {
          this.WizName= string.Empty;
          this.PostDateTo= DateTime.Now;
          this.WizType= string.Empty;
          this.IndexCode= string.Empty;
          this.CashAcct= string.Empty;
          this.CashCancel= string.Empty;
          this.FromItem= string.Empty;
          this.ToItem= string.Empty;
          this.Properties= string.Empty;
          this.RvalMethod= string.Empty;
          this.UseDLN= string.Empty;
          this.UsePCH= string.Empty;
          this.UsePCHNoSt= string.Empty;
          this.UseImport= string.Empty;
          this.CashExecut= string.Empty;
          this.ActType= string.Empty;
          this.FilterExe= string.Empty;
          this.CshRvToAct= string.Empty;
          this.MarkVar= string.Empty;
          this.ChngPrice= string.Empty;
          this.UseSemestr= string.Empty;
          this.CreateDate= DateTime.Now;
          this.CshCanclD= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IndexCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IndexRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashFrmBl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashCancel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItemGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RvalMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PriceSour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseDLN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsePCH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsePCHNoSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseImport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashDifBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashExecut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VarRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilterExe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CashErrRes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CshRvToAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MarkVar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChngPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseSemestr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CshLstRvBl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CshCanclD { get; set; }
    }
}