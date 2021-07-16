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
    public partial class OCFW 
    {
        public OCFW()
        {
          this.CFWName= string.Empty;
          this.LineNum= string.Empty;
          this.Postable= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFWName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Postable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FatherNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Levels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupMask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GroupLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExtrMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntrMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RateDifCFW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Attr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Direction { get; set; }
    }
}