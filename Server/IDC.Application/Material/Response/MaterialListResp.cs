using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Material.Response
{
    public class MaterialListResp
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string pt_no { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string pt_name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string pt_desc { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string pt_unit { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string pt_type { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public string pt_class { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? last_update_time { get; set; }
        /// <summary>
        /// 有效开始日期
        /// </summary>
        public DateTime? effect_start_time { get; set; }
        /// <summary>
        /// 有效结束日期
        /// </summary>
        public DateTime? effect_end_time { get; set; }
    }
}
