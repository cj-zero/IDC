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
    public partial class ODMW 
    {
        public ODMW()
        {
          this.Name= string.Empty;
          this.DestPath= string.Empty;
          this.Extantion= string.Empty;
          this.Delim= string.Empty;
          this.InclTitle= string.Empty;
          this.SetExp= string.Empty;
          this.NewRecs= string.Empty;
          this.Summary= string.Empty;
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
        [Browsable(false)]
        public int? CategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DestPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Extantion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Delim { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InclTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SetExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewRecs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Summary { get; set; }
    }
}