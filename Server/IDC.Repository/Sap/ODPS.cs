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
    public partial class ODPS 
    {
        public ODPS()
        {
          this.DeposType= string.Empty;
          this.DeposNum= 0;
          this.DeposDate= DateTime.Now;
          this.DeposCurr= string.Empty;
          this.BanckAcct= string.Empty;
          this.DeposAcct= string.Empty;
          this.DeposBrnch= string.Empty;
          this.Memo= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.AllocAcct= string.Empty;
          this.ChkType= string.Empty;
          this.DpsBank= string.Empty;
          this.DpostorNam= string.Empty;
          this.Printed= string.Empty;
          this.CrdBankAct= string.Empty;
          this.IsCard= string.Empty;
          this.Transfered= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.Splited= string.Empty;
          this.CreateDate= DateTime.Now;
          this.VatAct= string.Empty;
          this.ComissAct= string.Empty;
          this.ComissDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.Series= 0;
          this.DataSource= string.Empty;
          this.ObjType= string.Empty;
          this.DepostNorm= string.Empty;
          this.PostType= string.Empty;
          this.BankCountr= string.Empty;
          this.Canceled= string.Empty;
          this.CommisVat= string.Empty;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
          this.Project= string.Empty;
          this.ReconAfter= string.Empty;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.ComisCurr= string.Empty;
          this.SupplCode= string.Empty;
          this.IncomeAct= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeposType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DeposNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DeposDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeposCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BanckAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeposAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeposBrnch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FcTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllocAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpsBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpostorNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBankAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Splited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ComissAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Comission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ComissDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatTotlSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ComissnSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DepostNorm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CnclDps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CommisVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SeqCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Serial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReconAfter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
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
        public decimal? ComisFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatTotlFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ComisCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupplCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncomeAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IncomeLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IncomeFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IncomeSC { get; set; }
    }
}