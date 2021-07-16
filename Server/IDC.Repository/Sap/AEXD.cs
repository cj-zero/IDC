﻿using System;
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
    public partial class AEXD 
    {
        public AEXD()
        {
          this.ExpnsName= string.Empty;
          this.RevAcct= string.Empty;
          this.ExpnsAcct= string.Empty;
          this.TaxLiable= string.Empty;
          this.DataSource= string.Empty;
          this.VatGroupI= string.Empty;
          this.VatGroupO= string.Empty;
          this.DistrbMthd= string.Empty;
          this.In1099= string.Empty;
          this.ExpOfstAct= string.Empty;
          this.WTLiable= string.Empty;
          this.BaseMethod= string.Empty;
          this.Stock= string.Empty;
          this.LstPchPrce= string.Empty;
          this.SalseRpt= string.Empty;
          this.PchRpt= string.Empty;
          this.RevExmAcct= string.Empty;
          this.ExpnsExAct= string.Empty;
          this.RevRetAct= string.Empty;
          this.ExpnsType= string.Empty;
          this.OcrCode= string.Empty;
          this.TaxDisMthd= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.OcrCodeX= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.Project= string.Empty;
          this.Intrastat= string.Empty;
          this.GrsFreight= string.Empty;
          this.SacCode= string.Empty;
          this.FreighType= string.Empty;
          this.U_PRX_SID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpnsName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpnsAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RevFixSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpFixSum { get; set; }
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
        public string VatGroupI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroupO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistrbMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string In1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpOfstAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Stock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LstPchPrce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalseRpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PchRpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevExmAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpnsExAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevRetAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpnsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxDisMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCodeX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Intrastat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrsFreight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SacCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreighType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}