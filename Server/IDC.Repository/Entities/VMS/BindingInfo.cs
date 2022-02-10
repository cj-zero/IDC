using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDC.Repository.Dapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDC.Repository.Entities.VMS
{
    /// <summary>
    /// 设备绑定信息表
    /// </summary>
    [ConnectionString("VMSDbContext", "VMSDbContext")]
    public class BindingInfo
    {
        /// <summary>
        /// 绑定ID
        /// </summary>
        [Key]
        [Column("binding_id")]
        public string binding_id { get; set; }

        /// <summary>
        /// 设备GUID
        /// </summary>
        [Column("dev_guid")]
        public string dev_guid { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [Column("sn")]
        public string sn { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [Column("pn")]
        public string pn { get; set; }

        /// <summary>
        /// 设备类型:0-未知 1-下位机 2-中位机
        /// </summary>
        [Column("dev_type")]
        public int dev_type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("create_time")]
        public DateTime create_time { get; set; }

        /// <summary>
        /// 客户端原字符
        /// </summary>
        [Column("ClientQrString")]
        public string ClientQrString { get; set; }

        /// <summary>
        /// 服务端原字符
        /// </summary>
        [Column("ServiceQrString")]
        public string ServiceQrString { get; set; }
    }
}
