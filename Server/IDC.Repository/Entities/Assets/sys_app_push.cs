using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class sys_app_push
    {
        public int id { get; set; }
        public string push_cid { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public Nullable<int> content_id { get; set; }
        public Nullable<sbyte> content_type { get; set; }
        public string payload { get; set; }
        public Nullable<bool> has_push { get; set; }
        public Nullable<System.DateTime> push_time { get; set; }
        public System.DateTime created_on { get; set; }
    }
}
