using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    public class InsertAssetRequest
    {
        /// <summary>
        /// 资产Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public int category_id { get; set; }
        /// <summary>
        /// 资产类型：1-借用类型（需要归还）2-预约类型（到期自动归还）3-领用类型（不需要归还）
        /// </summary>
        public sbyte use_type { get; set; }
        /// <summary>
        /// 新增资产时，sn 如果需要批量写入时，请用英文,隔开
        /// </summary>
        public string sn { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string brand { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string spec_no { get; set; }
        /// <summary>
        /// 资产图片
        /// </summary>
        public string cover_img { get; set; }
        /// <summary>
        /// 存放地点
        /// </summary>
        public string place { get; set; }
        /// <summary>
        /// 是否需要使用签名
        /// </summary>
        public bool is_sign { get; set; }
        /// <summary>
        /// 预约是否要审核:0-不需要,1-要审核
        /// </summary>
        public bool is_audit { get; set; }
        /// <summary>
        /// 协议标题
        /// </summary>
        public string protocol_title { get; set; }
        /// <summary>
        /// 协议内容
        /// </summary>
        public string protocol_cont { get; set; }
        /// <summary>
        /// 数据添加来源 1-Erp 2-App
        /// </summary>
        public int data_add_source { get; set; }
        /// <summary>
        /// 使用说明
        /// </summary>
        public string instructions { get; set; }
        /// <summary>
        /// 是否开启日常保养 false-关闭 true-开启
        /// </summary>
        public bool is_open_maintain { get; set; }
        /// <summary>
        /// 保养事项
        /// </summary>
        public string maintain_matter { get; set; }
        /// <summary>
        /// 负责人账号列表
        /// </summary>
        public List<int> maintain_charge_user { get; set; }
        /// <summary>
        /// 实验室Id
        /// </summary>
        public int roomId { get; set; }
        /// <summary>
        /// 二维码
        /// </summary>
        public string qr_code { get; set; }

        public bool is_bts { get; set; } = false;
        /// <summary>
        /// 价格
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// 采购日期
        /// </summary>
        public DateTime? purchase_date { get; set; }
        /// <summary>
        /// 资产来源
        /// </summary>
        public int assets_source { get; set; }
        /// <summary>
        /// 售后联系人
        /// </summary>
        public string after_sale_contact { get; set; }
        /// <summary>
        /// 售后电话
        /// </summary>
        public string after_sale_tel { get; set; }
        /// <summary>
        /// 管理员Id
        /// </summary>
        public int admin_user_id { get; set; }
        /// <summary>
        /// 管理员Id
        /// </summary>
        public int admin_passport_id { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string color { get; set; }
        /// <summary>
        /// 采购单号
        /// </summary>
        public int purchase_order_no { get; set; }

        /// <summary>
        /// 是否开启巡检 
        /// </summary>
        public bool is_open_inspect { get; set; } = false;

        /// <summary>
        /// 动态属性
        /// </summary>
        public List<AssetsSpec> assets_spec_list { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string item_code { get; set; }
        /// <summary>
        /// 保修期
        /// </summary>
        public DateTime? guarantee_period { get; set; }
        /// <summary>
        /// 是否在资产列表显示(0:否  1:是)
        /// </summary>
        public bool is_show { get; set; }
        /// <summary>
        /// 是否定位器
        /// </summary>
        public bool is_position { get; set; }
        /// <summary>
        /// 是否开启定位
        /// </summary>
        public bool is_open_position { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal number { get; set; }

        public string customer_id { get; set; }
        public int passport_id { get; set; }
    }
    /// <summary>
    /// 资产动态属性
    /// </summary>
    public class AssetsSpec
    {
        /// <summary>
        /// 动态属性Id
        /// </summary>
        public int spec_id { get; set; }
        /// <summary>
        /// 动态属性值
        /// </summary>
        public string spec_val { get; set; }
    }
}
