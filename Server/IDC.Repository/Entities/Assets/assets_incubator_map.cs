using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_incubator_map
    {
        public int id { get; set; }
        public int assets_id { get; set; }
        public int floor { get; set; }
        public int channel_id { get; set; }
        public int room_id { get; set; }
        public int create_by { get; set; }
        public System.DateTime created_on { get; set; }
    }
}
