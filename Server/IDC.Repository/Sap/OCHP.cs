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
    public partial class OCHP 
    {
        public OCHP()
        {
          this.Chapter= string.Empty;
          this.Heading= string.Empty;
          this.SubHeading= string.Empty;
          this.Dscription= string.Empty;
          this.ChapterID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Chapter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Heading { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubHeading { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChapterID { get; set; }
    }
}