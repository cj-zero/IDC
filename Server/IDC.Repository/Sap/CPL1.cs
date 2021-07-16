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
    public partial class CPL1 
    {
        public CPL1()
        {
          this.ObjectID= string.Empty;
          this.Instance= string.Empty;
          this.ErrCode= string.Empty;
          this.MessageId= string.Empty;
          this.MessageDes= string.Empty;
          this.InstName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string MessageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MessageDes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstName { get; set; }
    }
}