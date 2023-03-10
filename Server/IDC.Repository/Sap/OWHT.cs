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
    public partial class OWHT 
    {
        public OWHT()
        {
          this.WTName= string.Empty;
          this.EffecDate= DateTime.Now;
          this.Category= string.Empty;
          this.BaseType= string.Empty;
          this.OffclCode= string.Empty;
          this.Account= string.Empty;
          this.IsPrgrss= string.Empty;
          this.Type= string.Empty;
          this.RoundType= string.Empty;
          this.WTCurrency= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.Concess= string.Empty;
          this.ApTdsAcc= string.Empty;
          this.ApSurAcc= string.Empty;
          this.ApCessAcc= string.Empty;
          this.ApHscAcc= string.Empty;
          this.ArTdsAcc= string.Empty;
          this.ArSurAcc= string.Empty;
          this.ArCessAcc= string.Empty;
          this.ArHscAcc= string.Empty;
          this.ReturnType= string.Empty;
          this.Inactive= string.Empty;
          this.CalBaseN= string.Empty;
          this.PymntRsnCd= string.Empty;
          this.DIOTRpt= string.Empty;
          this.TDSType= string.Empty;
          this.ApIgstAcc= string.Empty;
          this.ApCgstAcc= string.Empty;
          this.ApSgstAcc= string.Empty;
          this.ArIgstAcc= string.Empty;
          this.ArCgstAcc= string.Empty;
          this.ArSgstAcc= string.Empty;
          this.ApUtgstAcc= string.Empty;
          this.ApCsgstAcc= string.Empty;
          this.ArUtgstAcc= string.Empty;
          this.ArCsgstAcc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EffecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PrctBsAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OffclCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinTaxAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPrgrss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? WTTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Section { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Threshold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Surcharge { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Concess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Assessee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApTdsAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApSurAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApCessAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApHscAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArTdsAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArSurAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArCessAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArHscAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReturnType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inactive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InCSTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OutCSTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalBaseN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymntRsnCd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DIOTRpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TDSType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApIgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApCgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApSgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArIgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArCgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArSgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApUtgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApCsgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArUtgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArCsgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TransThres { get; set; }
    }
}