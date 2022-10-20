using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class room
    {
        [Key]
        public int room_id { get; set; }
        public string name { get; set; }
        public int open_mode { get; set; }
        public int join_mode { get; set; }
        public string remark { get; set; }
        public string image_url { get; set; }
        public bool bulletin_isopen { get; set; }
        public int user_id { get; set; }
        public System.DateTime create_time { get; set; }
        public int status { get; set; }
        public string customer_code { get; set; }
        public Nullable<bool> is_bts_room { get; set; }
        public sbyte create_source { get; set; }
        
        public string customer_id { get; set; }
    }
}
