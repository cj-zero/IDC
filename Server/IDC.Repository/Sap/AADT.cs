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
    public partial class AADT 
    {
        public AADT()
        {
          this.Descr= string.Empty;
          this.BalanceAct= string.Empty;
          this.ClrAcqAct= string.Empty;
          this.RevResvAct= string.Empty;
          this.OrdDprAct= string.Empty;
          this.OrdDprAcc= string.Empty;
          this.UnpDprAct= string.Empty;
          this.UnpDprAcc= string.Empty;
          this.SpDprAct= string.Empty;
          this.SpDprAcc= string.Empty;
          this.SaRevNAct= string.Empty;
          this.ReExpNAct= string.Empty;
          this.ReRevNAct= string.Empty;
          this.ReNBVeAct= string.Empty;
          this.ReNBVrAct= string.Empty;
          this.ClrDscAct= string.Empty;
          this.RevReAct= string.Empty;
          this.DataSource= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.ClearAccRe= string.Empty;
          this.RevResvClr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalanceAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClrAcqAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevResvAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrdDprAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrdDprAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnpDprAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnpDprAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDprAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDprAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaRevNAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReExpNAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReRevNAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReNBVeAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReNBVrAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClrDscAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevReAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
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
        public string ClearAccRe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevResvClr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapshotId { get; set; }
    }
}