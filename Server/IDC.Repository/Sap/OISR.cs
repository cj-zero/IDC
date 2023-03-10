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
    public partial class OISR 
    {
        public OISR()
        {
          this.Open_Date= DateTime.Now;
          this.Contact= string.Empty;
          this.Phone= string.Empty;
          this.Dscription= string.Empty;
          this.Answer= string.Empty;
          this.Status= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Open_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Open_Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? Task_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TaskType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Answer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
    }
}