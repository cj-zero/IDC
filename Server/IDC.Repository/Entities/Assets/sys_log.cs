using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class sys_log
    {
        public int id { get; set; }
        public int type { get; set; }
        public int user_id { get; set; }
        public string content { get; set; }
        public System.DateTime created_on { get; set; }
        public int passport_id { get; set; }
    }
}
