using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Nwcali
{
    public partial class accounts
    {
        public int passport_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public string SecurityStamp { get; set; }
        public string nickname { get; set; }
        public string realname { get; set; }
        public string head_image { get; set; }
        public string country_code { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public sbyte email_verify { get; set; }
        public sbyte gender { get; set; }
        public sbyte status { get; set; }
        public string access_token { get; set; }
        public string QQ { get; set; }
        public string Wechat { get; set; }
        public Nullable<System.DateTime> expire_time { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public Nullable<int> created_by { get; set; }
    }
}
