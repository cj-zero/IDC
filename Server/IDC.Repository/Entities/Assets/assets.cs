using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets
    {
        public int id { get; set; }
        public int category_id { get; set; }
        public sbyte use_type { get; set; }
        public string sn { get; set; }
        public string guid { get; set; }
        public string name { get; set; }
        public string assets_no { get; set; }
        public string brand { get; set; }
        public string spec_no { get; set; }
        public string cover_img { get; set; }
        public sbyte status { get; set; }
        public string place { get; set; }
        public decimal? lat { get; set; }
        public decimal? lng { get; set; }
        public bool is_sign { get; set; }
        public bool? is_audit { get; set; }
        public DateTime created_on { get; set; }
        public int? created_by { get; set; }
        public string customer_code { get; set; }
        public string protocol_title { get; set; }
        public string protocol_cont { get; set; }
        public bool? is_open_maintain { get; set; }
        public int? data_add_source { get; set; }
        public string instructions { get; set; }
        public string maintain_matter { get; set; }
        public string remark { get; set; }
        public bool? is_bts { get; set; }
        public sbyte bts_type { get; set; }
        public string warmbox_no { get; set; }
        public int mid_id { get; set; }
        public string dev_attrs { get; set; }
        public string qr_code { get; set; }
        public bool? is_delete { get; set; }
        public bool is_book { get; set; }
        public decimal? price { get; set; }
        public DateTime? purchase_date { get; set; }
        public int? assets_source { get; set; }
        public string after_sale_contact { get; set; }
        public string after_sale_tel { get; set; }
        public int? admin_user_id { get; set; }
        public int? old_category_id { get; set; }
        public string unit { get; set; }
        public string color { get; set; }
        public string serial { get; set; }
        public long? purchase_order_no { get; set; }
        public string item_code { get; set; }
        public int? receipt_no { get; set; }
        public string item_code_dscription { get; set; }
        public bool is_open_inspect { get; set; }
        public DateTime? guarantee_period { get; set; }
        public bool is_private { get; set; }
        public bool? is_show { get; set; }
        public bool? is_position { get; set; }
        public bool? is_open_position { get; set; }
        public decimal? number { get; set; }

        public string customer_id { get; set; }
        public int? admin_passport_id { get; set; }


    }
}
