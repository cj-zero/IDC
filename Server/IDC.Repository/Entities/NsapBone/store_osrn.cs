using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class store_osrn 
    {
        public store_osrn()
        {
          this.ItemCode= string.Empty;
          this.SysNumber= 0;
          this.DistNumber= string.Empty;
          this.MnfSerial= string.Empty;
          this.LotNumber= string.Empty;
          this.ExpDate= DateTime.Now;
          this.MnfDate= DateTime.Now;
          this.InDate= DateTime.Now;
          this.GrntStart= DateTime.Now;
          this.GrntExp= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.Location= string.Empty;
          this.Status= string.Empty;
          this.Notes= string.Empty;
          this.DataSource= string.Empty;
          this.Transfered= string.Empty;
          this.ObjType= string.Empty;
          this.itemName= string.Empty;
          this.UpdateDate= DateTime.Now;
        }


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int SysNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MnfSerial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LotNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExpDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MnfDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? InDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? GrntStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? GrntExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notes { get; set; }
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
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string itemName { get; set; }
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
    }
}