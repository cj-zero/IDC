using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.IDC
{
    /// <summary>
	/// 用户表
	/// </summary>
    [ConnectionString("IDCDbContext", "IDCReadDbContext")]
    public class Handler
    {
        public Handler() 
        {

        }
        /// <summary>
        /// 序号
        /// </summary>
        [Description("序号")]
        [Key]
        public int Number { get; set; }

        /// <summary>
        /// 传入内容
        /// </summary>
        [Description("传入内容")]
        public string Content { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [Description("数据来源")]
        public string DataSources { get; set; }

        /// <summary>
        /// 数据状态
        /// </summary>
        [Description("数据状态")]
        public int Status { get; set; }

        /// <summary>
        /// 传入内容
        /// </summary>
        [Description("传入内容")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Description("修改时间")]
        public string UpdateTime { get; set; }
    }
}
