using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_book
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int assets_id { get; set; }
        public System.DateTime start_time { get; set; }
        public System.DateTime over_time { get; set; }
        public bool is_sign { get; set; }
        public Nullable<bool> is_audit { get; set; }
        public long audit_user_id { get; set; }
        public Nullable<sbyte> audit_status { get; set; }
        public string audit_comment { get; set; }
        public int status { get; set; }
        public string use_to { get; set; }
        public System.DateTime status_time { get; set; }
        public System.DateTime create_time { get; set; }
        public int has_returned { get; set; }
        public sbyte use_type { get; set; }
        public string sign_img { get; set; }
        public string place { get; set; }
        public int is_bts { get; set; }
        public Nullable<int> room_id { get; set; }
        public Nullable<decimal> number { get; set; }

        public int? passport_id { get; set; }
    }
}
