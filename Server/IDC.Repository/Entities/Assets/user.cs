using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class user
    {
        [Key]
        public int user_id { get; set; }
        public Nullable<int> passport_id { get; set; }
        public string wx_openid { get; set; }
        public string wx_unionid { get; set; }
        public string token { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public string real_name { get; set; }
        public string country_code { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public Nullable<bool> email_verify { get; set; }
        public int gender { get; set; }
        public string head_image { get; set; }
        public string center_bg_img { get; set; }
        public string remark { get; set; }
        public bool is_audit { get; set; }
        public Nullable<System.DateTime> audit_time { get; set; }
        public int customer_id { get; set; }
        public string company_name { get; set; }
        public string customer_code { get; set; }
        public int invite_user_id { get; set; }
        public bool is_prom { get; set; }
        public decimal login_long { get; set; }
        public decimal login_lat { get; set; }
        public Nullable<System.DateTime> login_time { get; set; }
        public int login_count { get; set; }
        public string push_cid { get; set; }
        public int status { get; set; }
        public System.DateTime status_time { get; set; }
        public string nsap_user_id { get; set; }
        public sbyte role { get; set; }
        public Nullable<int> frozen_points { get; set; }
        public Nullable<long> points { get; set; }
        public string signature { get; set; }
        public System.DateTime create_time { get; set; }
        public string department { get; set; }
    }
}
