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
    public partial class OUSG 
    {
        public OUSG()
        {
          this.Usage= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.UserSign= string.Empty;
          this.TaxOnly= string.Empty;
          this.CFOPIIS= string.Empty;
          this.CFOPIOS= string.Empty;
          this.CFOPII= string.Empty;
          this.CFOPOIS= string.Empty;
          this.CFOPOOS= string.Empty;
          this.CFOPOE= string.Empty;
          this.Descr= string.Empty;
          this.FreeChrgBP= string.Empty;
          this.ThirdParty= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Usage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PostTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFOPIIS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFOPIOS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFOPII { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFOPOIS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFOPOOS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFOPOE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeChrgBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ThirdParty { get; set; }
    }
}