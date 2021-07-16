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
    public partial class CTNS 
    {
        public CTNS()
        {
          this.ObjectId= string.Empty;
          this.EnableAsyN= string.Empty;
          this.EnableTn= string.Empty;
          this.EnablePTn= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableAsyN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableTn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnablePTn { get; set; }
    }
}