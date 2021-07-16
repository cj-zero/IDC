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
    public partial class AOB1 
    {
        public AOB1()
        {
          this.ObjName= string.Empty;
          this.SendIntrnl= string.Empty;
          this.Confirmed1= string.Empty;
          this.ConfDate1= DateTime.Now;
          this.SendEMail= string.Empty;
          this.E_Mail= string.Empty;
          this.Confirmed2= string.Empty;
          this.ConfDate2= DateTime.Now;
          this.SendSMS= string.Empty;
          this.PortNum= string.Empty;
          this.Confirmed3= string.Empty;
          this.ConfDate3= DateTime.Now;
          this.SendFax= string.Empty;
          this.Fax= string.Empty;
          this.Confirmed4= string.Empty;
          this.ConfDate4= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendIntrnl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Confirmed1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ConfDate1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ConfTime1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendEMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Confirmed2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ConfDate2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ConfTime2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendSMS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PortNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Confirmed3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ConfDate3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ConfTime3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Confirmed4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ConfDate4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ConfTime4 { get; set; }
    }
}