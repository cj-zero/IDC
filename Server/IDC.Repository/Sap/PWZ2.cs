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
    public partial class PWZ2 
    {
        public PWZ2()
        {
          this.BnkAccount= string.Empty;
          this.Checked= string.Empty;
          this.PymDisc= string.Empty;
          this.PymType= string.Empty;
          this.InterimAct= string.Empty;
          this.BnkCountry= string.Empty;
          this.BnkCode= string.Empty;
          this.BnkAccNo= string.Empty;
          this.FatherLn= string.Empty;
          this.NegativPym= string.Empty;
          this.NegPymBnk= string.Empty;
          this.NegCountry= string.Empty;
          this.NegPymAcct= string.Empty;
          this.PaymenMean= string.Empty;
          this.IBAN= string.Empty;
          this.SwiftNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxIncom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxOutgo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpectBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Checked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpIntBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InterimAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkAccNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegativPym { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegPymBnk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegPymAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymenMean { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SwiftNum { get; set; }
    }
}