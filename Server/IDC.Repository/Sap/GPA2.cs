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
    public partial class GPA2 
    {
        public GPA2()
        {
          this.Name= string.Empty;
          this.Descript= string.Empty;
          this.PostDateFr= DateTime.Now;
          this.PostDateTo= DateTime.Now;
          this.ItemCodeFr= string.Empty;
          this.ItemCodeTo= string.Empty;
          this.AdditFilt= string.Empty;
          this.SearchCond= string.Empty;
          this.PropList= string.Empty;
          this.DisplInact= string.Empty;
          this.UseGroups= string.Empty;
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
        public string Descript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDateFr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCodeFr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCodeTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmsGrpCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdditFilt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SearchCond { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PropList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DisplInact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseGroups { get; set; }
    }
}