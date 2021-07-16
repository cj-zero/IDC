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
    public partial class OPRO 
    {
        public OPRO()
        {
          this.MapID= 0;
          this.Code= 0;
          this.Type= string.Empty;
          this.Name= string.Empty;
          this.IsBlob= string.Empty;
          this.TValue= string.Empty;
          this.Encoding= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int MapID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsBlob { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] BValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Encoding { get; set; }
    }
}