using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using IDC.Infrastructure.Returned;
using IDC.Application.Staff.Request;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBase;
using Dapper;
using IDC.Application.Basics;
using IDC.Application.SSO;

namespace IDC.Application.Staff
{
    public class StaffApp : BaseApp
    {
        public StaffApp(IRepositoryBase repositoryBase, IAuth auth) : base(auth, repositoryBase)
        {
        }
        public async Task<TableData> GetStaffList(QueryStaffListReq req)
        {
            var result = new TableData();
            //var sql = @"select a.user_nm,c.dep_nm,b.out_date,d.post_nm,b.upd_dt from base_user a 
            //        left join base_user_detail b on a.user_id = b.user_id 
            //        left join base_dep c on b.dep_id = c.dep_id 
            //        left join base_post d on b.post_id = d.post_id where 1=1";
            //var Parameters = new DynamicParameters();
            //if (!string.IsNullOrWhiteSpace(req.StartTime))
            //{
            //    sql += " and b.upd_dt > @StartTime"; Parameters.Add("StartTime", req.StartTime);
            //}
            //if (!string.IsNullOrWhiteSpace(req.EndTime))
            //{
            //    sql += " and b.upd_dt < @EndTime"; Parameters.Add("EndTime", DateTime.Parse(req.EndTime).AddDays(1));
            //}

            //var userList = (await _repositoryBase.FindAsync<base_user>(sql,Parameters)).Select(u => new
            //{
            //    StaffName = u.user_nm,
            //    OrgName = u.dep_nm,
            //    IsDimission = u.out_date.ToString() == "0000-00-00" ? false : true,
            //    PositionName = u.post_nm,
            //    UpdateTime = u.upd_dt
            //}).ToList();

            //result.Data = userList;
            //result.Count = userList.Count();

            return result;
        }

    }
}
