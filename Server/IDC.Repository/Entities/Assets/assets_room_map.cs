using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_room_map
    {
        public int id { get; set; }
        public int assets_id { get; set; }
        public int room_id { get; set; }
        public System.DateTime created_on { get; set; }
        public sbyte is_commonly_assets { get; set; }
        public System.DateTime make_top_time { get; set; }
        public int room2_id { get; set; }
    }
}
