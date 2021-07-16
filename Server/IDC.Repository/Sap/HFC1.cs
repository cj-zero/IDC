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
    public partial class HFC1 
    {
        public HFC1()
        {
          this.formNum= string.Empty;
          this.ItemUID= string.Empty;
          this.ColUID= string.Empty;
          this.HideVal= string.Empty;
          this.AltVal= string.Empty;
          this.DataSource= string.Empty;
          this.Transfered= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FuncID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string formNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HideVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PanelID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
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
    }
}