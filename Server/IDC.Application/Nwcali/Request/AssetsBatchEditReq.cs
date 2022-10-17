using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    public class AssetsBatchEditReq
    {
        public List<AssetsBatchSelect> select_list { get; set; }
        public int category_id { get; set; }
        public string place { get; set; }
        public sbyte use_type { get; set; }
        public int assets_source { get; set; }
        public decimal price { get; set; }
        public int room_id { get; set; }
        public int admin_user_id { get; set; }
        /// <summary>
        /// 是否签名  -1:不做修改  0：false 1:true
        /// </summary>
        public int is_sign { get; set; }
        /// <summary>
        /// 是否审核 -1:不做修改  0：false 1:true
        /// </summary>
        public int is_audit { get; set; }
        public string instructions { get; set; }
        public string after_sale_contact { get; set; }
        public string after_sale_tel { get; set; }
        public int is_open_maintain { get; set; }
        public string maintain_matter { get; set; }
        public List<int> assets_maintain_user { get; set; }
        public DateTime guarantee_period { get; set; }
    }
    public class AssetsBatchSelect
    {
        public int Id { get; set; }
        public int use_type { get; set; }
        public int room_id { get; set; }
    }
}
