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
    public partial class OPLN 
    {
        public OPLN()
        {
          this.ListName= string.Empty;
          this.DataSource= string.Empty;
          this.IsGrossPrc= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.ValidFor= string.Empty;
          this.ValidFrom= DateTime.Now;
          this.ValidTo= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.PrimCurr= string.Empty;
          this.AddCurr1= string.Empty;
          this.AddCurr2= string.Empty;
          this.RoundRule= string.Empty;
          this.RndFrmtInt= string.Empty;
          this.RndFrmtDec= string.Empty;
          this.U_PRX_SID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ListName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BASE_NUM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Factor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RoundSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SPPCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsGrossPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
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
        public string ValidFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrimCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddCurr1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddCurr2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RndFrmtInt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RndFrmtDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}