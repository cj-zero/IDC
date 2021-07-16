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
    public partial class ABT1 
    {
        public ABT1()
        {
          this.GLAct= string.Empty;
          this.Project= string.Empty;
          this.PrftCenter= string.Empty;
          this.VatCode= string.Empty;
          this.PrftCent2= string.Empty;
          this.PrftCent3= string.Empty;
          this.PrftCent4= string.Empty;
          this.PrftCent5= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCenter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent5 { get; set; }
    }
}