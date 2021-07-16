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
    public partial class OPRF 
    {
        public OPRF()
        {
          this.ExPref1= string.Empty;
          this.ExPref2= string.Empty;
          this.ExPref3= string.Empty;
          this.ExPref4= string.Empty;
          this.ExPref5= string.Empty;
          this.ExPref6= string.Empty;
          this.ExPref7= string.Empty;
          this.ExPref8= string.Empty;
          this.ExPref9= string.Empty;
          this.ExPref10= string.Empty;
          this.ExPref11= string.Empty;
          this.ExPref12= string.Empty;
          this.ExPref13= string.Empty;
          this.ExPref14= string.Empty;
          this.ExPref15= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExPref15 { get; set; }
    }
}