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
    public partial class PCI1 
    {
        public PCI1()
        {
          this.BPMNElId= string.Empty;
          this.BPMNElDes= string.Empty;
          this.ParamType= string.Empty;
          this.ParamKey= string.Empty;
          this.ParamVal= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string BPMNElId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPMNElDes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamVal { get; set; }
    }
}