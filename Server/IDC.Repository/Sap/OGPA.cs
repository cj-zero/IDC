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
    public partial class OGPA 
    {
        public OGPA()
        {
          this.Name= string.Empty;
          this.CreateDate= DateTime.Now;
          this.Status= string.Empty;
          this.Remarks= string.Empty;
          this.WizType= string.Empty;
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
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? nGPAdj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? nPCAdj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? nGPFail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? nPCFail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? nJECreate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? nMRVCreate { get; set; }
    }
}