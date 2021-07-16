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
    public partial class ITM10 
    {
        public ITM10()
        {
          this.ISOriCntry= string.Empty;
          this.ISItemType= string.Empty;
          this.ISSerSupMt= string.Empty;
          this.ISSerPayMt= string.Empty;
          this.ISOrCRYImp= string.Empty;
          this.ISOrCRYExp= string.Empty;
          this.ISUseWeigh= string.Empty;
          this.ISRelevant= string.Empty;
          this.ISStatCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISCommCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISSubMasUn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ISFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISOrCSTImp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISOrCSTExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISNaTraImp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISNaTraExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISStProImp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISStProExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISOriCntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISSerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISSerSupMt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISSerPayMt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISOrCRYImp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISOrCRYExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISUseWeigh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISRelevant { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISStatCode { get; set; }
    }
}