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
    public partial class OBPD 
    {
        public OBPD()
        {
          this.DatSubType= string.Empty;
          this.DatSubKey= string.Empty;
          this.DatSubKey2= string.Empty;
          this.TableName= string.Empty;
          this.KeyValue1= string.Empty;
          this.KeyValue2= string.Empty;
          this.KeyValue3= string.Empty;
          this.KeyValue4= string.Empty;
          this.KeyValue5= string.Empty;
          this.FieldName= string.Empty;
          this.EncryptVal= string.Empty;
          this.EncryptIV= string.Empty;
          this.CreateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatSubKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatSubKey2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyValue1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyValue2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyValue3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyValue4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyValue5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTime { get; set; }
    }
}