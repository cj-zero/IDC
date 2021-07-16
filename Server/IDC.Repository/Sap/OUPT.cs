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
    public partial class OUPT 
    {
        public OUPT()
        {
          this.Name= string.Empty;
          this.FathId= string.Empty;
          this.IsItem= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Options { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string FathId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Levels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}