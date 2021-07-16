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
    public partial class ISW1 
    {
        public ISW1()
        {
          this.CardName= string.Empty;
          this.CardType= string.Empty;
          this.NatOfTrans= string.Empty;
          this.StatProc= string.Empty;
          this.CustProc= string.Empty;
          this.TransMode= string.Empty;
          this.Incoterms= string.Empty;
          this.PortEnEx= string.Empty;
          this.BPVATRegNo= string.Empty;
          this.DomFrgID= string.Empty;
          this.CtryOrig= string.Empty;
          this.BPCountry= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatOfTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Incoterms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PortEnEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPVATRegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DomFrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtryOrig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPCountry { get; set; }
    }
}