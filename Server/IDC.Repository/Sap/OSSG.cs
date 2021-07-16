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
    public partial class OSSG 
    {
        public OSSG()
        {
          this.Name= string.Empty;
          this.CustGroup= string.Empty;
          this.EnEditTime= string.Empty;
          this.EnReject= string.Empty;
          this.EnResign= string.Empty;
          this.EnFollowup= string.Empty;
          this.EnSign= string.Empty;
          this.EnStarRat= string.Empty;
          this.EnActDura= string.Empty;
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
        public string CustGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnEditTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnReject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnResign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnFollowup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnStarRat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnActDura { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? AdBoardId { get; set; }
    }
}