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
    public partial class OINS 
    {
        public OINS()
        {
          this.customer= string.Empty;
          this.custmrName= string.Empty;
          this.directCsmr= string.Empty;
          this.drctCsmNam= string.Empty;
          this.manufSN= string.Empty;
          this.internalSN= string.Empty;
          this.warranty= string.Empty;
          this.wrrntyStrt= DateTime.Now;
          this.wrrntyEnd= DateTime.Now;
          this.responsUnt= string.Empty;
          this.itemCode= string.Empty;
          this.itemName= string.Empty;
          this.manufDate= DateTime.Now;
          this.dlvryDate= DateTime.Now;
          this.cntctPhone= string.Empty;
          this.street= string.Empty;
          this.block= string.Empty;
          this.zip= string.Empty;
          this.city= string.Empty;
          this.county= string.Empty;
          this.country= string.Empty;
          this.state= string.Empty;
          this.instLction= string.Empty;
          this.cntrctStrt= DateTime.Now;
          this.cntrctEnd= DateTime.Now;
          this.attachment= string.Empty;
          this.objType= string.Empty;
          this.createDate= DateTime.Now;
          this.updateDate= DateTime.Now;
          this.Building= string.Empty;
          this.status= string.Empty;
          this.Transfered= string.Empty;
          this.AddrType= string.Empty;
          this.StreetNo= string.Empty;
          this.BPType= string.Empty;
          this.DPPStatus= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string customer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string custmrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? contactCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string directCsmr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string drctCsmNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string manufSN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string internalSN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string warranty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? wrrntyStrt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? wrrntyEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? responsVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string responsUnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string itemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string itemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? itemGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? manufDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? delivery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? deliveryNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? invoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? invoiceNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? dlvryDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string cntctPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string block { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string zip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string county { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string instLction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? contract { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? cntrctStrt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? cntrctEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string objType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? createDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? replcIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? repByIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? technician { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? territory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}