using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_category
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public int sort_idx { get; set; }
        public string customer_code { get; set; }
        public int data_source { get; set; }
        public int status { get; set; }
        public string type_url { get; set; }
        public string remark { get; set; }
        public int old_category_id { get; set; }
        public string customer_id { get; set; }

    }
}
