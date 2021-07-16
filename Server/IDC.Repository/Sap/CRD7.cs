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
    public partial class CRD7 
    {
        public CRD7()
        {
          this.TaxId0= string.Empty;
          this.TaxId1= string.Empty;
          this.TaxId2= string.Empty;
          this.TaxId3= string.Empty;
          this.TaxId4= string.Empty;
          this.TaxId5= string.Empty;
          this.TaxId6= string.Empty;
          this.TaxId7= string.Empty;
          this.TaxId8= string.Empty;
          this.TaxId9= string.Empty;
          this.TaxId10= string.Empty;
          this.TaxId11= string.Empty;
          this.ECCNo= string.Empty;
          this.CERegNo= string.Empty;
          this.CERange= string.Empty;
          this.CEDivis= string.Empty;
          this.CEComRate= string.Empty;
          this.SefazDate= DateTime.Now;
          this.TaxId12= string.Empty;
          this.TaxId13= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? CNAEId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECCNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CERegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CERange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CEDivis { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CEComRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SefazDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId13 { get; set; }
    }
}