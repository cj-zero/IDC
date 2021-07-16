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
    public partial class AWL3 
    {
        public AWL3()
        {
          this.Note= string.Empty;
          this.Creator= string.Empty;
          this.NoteDate= DateTime.Now;
          this.Access= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WFInstID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NoteDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Access { get; set; }
    }
}