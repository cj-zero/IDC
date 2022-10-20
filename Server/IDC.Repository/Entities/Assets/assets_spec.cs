using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_spec
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string spec_name { get; set; }
        public sbyte input_type { get; set; }
        public bool can_null { get; set; }
        public string customer_code { get; set; }
        public string customer_id { get; set; }

    }
}
