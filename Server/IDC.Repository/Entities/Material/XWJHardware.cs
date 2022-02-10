using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Material
{
    [ConnectionString("Nsap4MaterialDbContext", "Nsap4MaterialDbContext")]
    public class XWJHardware
    {
        /// <summary>
        /// 自增Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 下位机硬件版型号
        /// </summary>
        public string XWJSn { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
