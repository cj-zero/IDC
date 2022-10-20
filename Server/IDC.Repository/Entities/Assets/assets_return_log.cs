using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_return_log
    {
        public int id { get; set; }
        public int assets_id { get; set; }
        public int user_id { get; set; }
        public string place { get; set; }
        public decimal lng { get; set; }
        public decimal lat { get; set; }
        public int rel_id { get; set; }
        public System.DateTime created_on { get; set; }
        public int has_confirm { get; set; }
        public string return_img { get; set; }
        public string remark { get; set; }
    }
}
