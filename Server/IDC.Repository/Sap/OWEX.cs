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
    public partial class OWEX 
    {
        public OWEX()
        {
          this.ProcInstId= string.Empty;
          this.ActId= string.Empty;
          this.DataContex= string.Empty;
          this.LastUpdate= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? IsActive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? IsConCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? IsScope { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ProcInstId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ProcDefId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ActId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataContex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? B1WFInstId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastUpdate { get; set; }
    }
}