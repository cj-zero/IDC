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
    public partial class OEML 
    {
        public OEML()
        {
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.ObjType= string.Empty;
          this.EMailAddr= string.Empty;
          this.SendDate= DateTime.Now;
          this.U_NAME= string.Empty;
          this.Subject= string.Empty;
          this.Body= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EMailAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? USERID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Subject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Body { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
    }
}