using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class app_notice
    {
        public int id { get; set; }
        public sbyte type { get; set; }
        public int user_id { get; set; }
        public int rel_id { get; set; }
        public Nullable<sbyte> rel_type { get; set; }
        public int from_user_id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public bool has_read { get; set; }
        public System.DateTime created_on { get; set; }
        public int msg_operation_type { get; set; }
        public string url { get; set; }
    }
}
