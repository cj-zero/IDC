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
    public partial class IGN26 
    {
        public IGN26()
        {
          this.SuplyType= string.Empty;
          this.DocType= string.Empty;
          this.TransDocNo= string.Empty;
          this.TransDate= DateTime.Now;
          this.VehicleTyp= string.Empty;
          this.VehicleNo= string.Empty;
          this.EWayBillNo= string.Empty;
          this.EwbDate= DateTime.Now;
          this.FrmTraName= string.Empty;
          this.FrmAddres1= string.Empty;
          this.FrmAddres2= string.Empty;
          this.FrmZipCode= string.Empty;
          this.ActFrmStat= string.Empty;
          this.ToTraName= string.Empty;
          this.ToAddres1= string.Empty;
          this.ToAddres2= string.Empty;
          this.ToZipCode= string.Empty;
          this.ActToState= string.Empty;
          this.FrmGSTN= string.Empty;
          this.FrmState= string.Empty;
          this.ToGSTN= string.Empty;
          this.ToState= string.Empty;
          this.FrmPlace= string.Empty;
          this.ToPlace= string.Empty;
          this.TransID= string.Empty;
          this.TransName= string.Empty;
          this.ExpireDate= DateTime.Now;
          this.ObjectType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SuplyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SubSplyTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Distance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransDocNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TransDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VehicleTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VehicleNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EWayBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EwbDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmTraName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmAddres1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmAddres2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActFrmStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToTraName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToAddres1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToAddres2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActToState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmGSTN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToGSTN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MainHsnEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmPlace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToPlace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExpireDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TspEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TspLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransType { get; set; }
    }
}