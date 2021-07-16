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
    public partial class TDR1 
    {
        public TDR1()
        {
          this.KeySeg1= string.Empty;
          this.KeySeg2= string.Empty;
          this.KeySeg3= string.Empty;
          this.KeySeg4= string.Empty;
          this.KeySeg5= string.Empty;
          this.KeySeg6= string.Empty;
          this.KeySeg7= string.Empty;
          this.KeySeg8= string.Empty;
          this.KeySeg9= string.Empty;
          this.KeySeg10= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocAbs { get; set; }
    }
}