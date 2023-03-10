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
    public partial class OOPR 
    {
        public OOPR()
        {
          this.CardCode= string.Empty;
          this.OpenDate= DateTime.Now;
          this.DifType= string.Empty;
          this.PredDate= DateTime.Now;
          this.Memo= string.Empty;
          this.Status= string.Empty;
          this.StatusRem= string.Empty;
          this.Transfered= string.Empty;
          this.CardName= string.Empty;
          this.CloseDate= DateTime.Now;
          this.Name= string.Empty;
          this.ChnCrdCode= string.Empty;
          this.ChnCrdName= string.Empty;
          this.PrjCode= string.Empty;
          this.attachment= string.Empty;
          this.DocType= string.Empty;
          this.DocChkbox= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.OpprType= string.Empty;
          this.DPPStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.EncryptIV= string.Empty;
          this.U_PRX_SID= string.Empty;
          this.U_job_id= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CprCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntCat1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntCat2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntCat3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OpenDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DifType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PredDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxSumLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSumLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PrcnProf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumProfL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumProfS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatusRem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RealSumLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RealSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RealProfL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RealProfS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CloPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? StepLast { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastSlp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Territory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChnCrdCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChnCrdName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CardGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChnCrdCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocChkbox { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
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
        public string OpprType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_job_id { get; set; }
    }
}