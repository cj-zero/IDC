using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_admin_user
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string customer_code { get; set; }
        public int role { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string remark { get; set; }
        public string customer_id { get; set; }
        public int passport_id { get; set; }
        
    }
}
