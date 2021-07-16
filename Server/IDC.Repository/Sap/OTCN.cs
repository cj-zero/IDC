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
    public partial class OTCN 
    {
        public OTCN()
        {
          this.CCDNum= string.Empty;
          this.Date= DateTime.Now;
          this.CustTerm= string.Empty;
          this.CntrOrigin= string.Empty;
          this.DirectImp= string.Empty;
          this.CardCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCDNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntrOrigin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DirectImp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
    }
}