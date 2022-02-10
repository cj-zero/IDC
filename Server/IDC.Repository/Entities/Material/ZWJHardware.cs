using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Material
{
    /// <summary>
    /// 中位机硬件
    /// </summary>
    [ConnectionString("Nsap4MaterialDbContext", "Nsap4MaterialDbContext")]
    public class ZWJHardware
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 中位机软件版本Id
        /// </summary>
        public int ZWJSoftwareVersionId { get; set; }

        /// <summary>
        /// 中位机硬件序列号
        /// </summary>
        public string ZWJSn { get; set; }
    }
}
