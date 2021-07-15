using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBase
{
    /// <summary>
	/// 用户表
	/// </summary>
    [ConnectionString("IDCDbContext", "IDCReadDbContext")]
    public partial class IDC_User 
    {
        public IDC_User()
        {
        }


        /// <summary>
        /// 用户id
        /// </summary>
        [Description("用户id")]
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [Description("用户名称")]
        public string UserName { get; set; }
        /// <summary>
        /// 来源系统
        /// </summary>
        [Description("来源系统")]
        public string SystemName { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        [Description("账户")]
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Description("密码")]
        public string Pwd { get; set; }
        /// <summary>
        /// 来源系统key
        /// </summary>
        [Description("来源系统key")]
        public string SystemKey { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Description("创建时间")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Description("更新时间")]
        public DateTime UPDATED_TIME { get; set; }
       
    }
}