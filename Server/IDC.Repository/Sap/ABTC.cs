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
    public partial class ABTC 
    {
        public ABTC()
        {
          this.InOpCode= string.Empty;
          this.PstTrans= string.Empty;
          this.BPorAct= string.Empty;
          this.PstMethod= string.Empty;
          this.ActFee= string.Empty;
          this.ProjFee= string.Empty;
          this.PrftCntFee= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.Descript= string.Empty;
          this.PrftCntFe2= string.Empty;
          this.PrftCntFe3= string.Empty;
          this.PrftCntFe4= string.Empty;
          this.PrftCntFe5= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InOpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PstTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPorAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PstMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProjFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCntFee { get; set; }
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
        public string Descript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCntFe2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCntFe3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCntFe4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCntFe5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
    }
}