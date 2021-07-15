﻿using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBase
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBaseDbContext","NsapBaseReadDbContext")]
    public partial class base_user_detail 
    {
        public base_user_detail()
        {
          this.staff_no= string.Empty;
          this.att_no= string.Empty;
          this.dep_id= 0;
          this.post_id= 0;
          this.nation= string.Empty;
          this.birthday= DateTime.Now;
          this.birth_place= string.Empty;
          this.id_card= string.Empty;
          this.id_addr= string.Empty;
          this.now_addr= string.Empty;
          this.bank_card= string.Empty;
          this.bank_info= string.Empty;
          this.ssc_card= string.Empty;
          this.ss_card= string.Empty;
          this.fund_card= string.Empty;
          this.ice_contact= string.Empty;
          this.ice_tel= string.Empty;
          this.college= string.Empty;
          this.major= string.Empty;
          this.degree= string.Empty;
          this.language= string.Empty;
          this.computer= string.Empty;
          this.specialty= string.Empty;
          this.cert= string.Empty;
          this.work_date= DateTime.Now;
          this.try_date= DateTime.Now;
          this.on_date= DateTime.Now;
          this.on_note= string.Empty;
          this.out_date= DateTime.Now;
          this.job_way= string.Empty;
          this.job_title= string.Empty;
          this.contact_beg_dd= DateTime.Now;
          this.contact_end_dd= DateTime.Now;
          this.introducer= string.Empty;
          this.office_addr= string.Empty;
          this.main_task= string.Empty;
          this.hire_way= string.Empty;
          this.hire_name= string.Empty;
          this.hire_tel= string.Empty;
          this.health= string.Empty;
          this.upd_dt= DateTime.Now;
          this.picture= string.Empty;
          this.cardenddate= DateTime.Now;
          this.religion= string.Empty;
          this.politics_status= string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int user_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string staff_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string att_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int dep_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int post_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ushort sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string nation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public sbyte married { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public float height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public float weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string birth_place { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string id_card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string id_addr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string now_addr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string bank_card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string bank_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ssc_card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ss_card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string fund_card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ice_contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ice_tel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string college { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string major { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string degree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string computer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string specialty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string cert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime work_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime try_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime on_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string on_note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime out_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string job_way { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string job_title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime contact_beg_dd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime contact_end_dd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string introducer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string office_addr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool is_pay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool is_att { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public sbyte is_eat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public sbyte is_stay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public sbyte trial_month { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string main_task { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string hire_way { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string hire_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string hire_tel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string health { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime upd_dt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public sbyte is_homepage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string picture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] probation_salary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] full_salary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? cardenddate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? resume_file_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string religion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string politics_status { get; set; }
    }
}