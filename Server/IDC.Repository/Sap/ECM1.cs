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
    public partial class ECM1 
    {
        public ECM1()
        {
          this.ParamType= string.Empty;
          this.ParamVisib= string.Empty;
          this.ParamName= string.Empty;
          this.ParamValue= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.ParamPrms= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? StrIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamVisib { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
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
        public short? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamPrms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UIorder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Type { get; set; }
    }
}