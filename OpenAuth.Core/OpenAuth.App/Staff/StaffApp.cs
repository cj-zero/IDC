using Infrastructure.Extensions;
using OpenAuth.App.Interface;
using OpenAuth.App.Staff.Request;
using OpenAuth.App.Response;
using OpenAuth.Repository.Domain;
using OpenAuth.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace OpenAuth.App.Staff
{
    public class StaffApp : OnlyUnitWorkBaeApp
    {
        public async Task<TableData> GetStaffList(QueryStaffListReq req)
        {
            var result = new TableData();

            var query = from a in UnitWork.Find<base_user>(null)
                        join b in UnitWork.Find<base_user_detail>(null) on (int)a.user_id equals b.user_id into ab
                        from b in ab.DefaultIfEmpty()
                        join c in UnitWork.Find<base_dep>(null) on b.dep_id equals c.dep_id into bc
                        from c in bc.DefaultIfEmpty()
                        join d in UnitWork.Find<base_post>(null) on b.post_id equals d.post_id into bd
                        from d in bd.DefaultIfEmpty()
                        select new { StaffName = a.user_nm, LogInName = a.log_nm, OrgName = c.dep_nm, IsDimission = b.out_date.ToString()=="0000-00-00"?false:true,PositionName= d.post_nm,UpdateTime= b.upd_dt};
            query = query.WhereIf(!string.IsNullOrWhiteSpace(req.StaffName), u => u.StaffName.Contains(req.StaffName))
                 .WhereIf(!string.IsNullOrWhiteSpace(req.StartTime), q => q.UpdateTime > DateTime.Parse(req.StartTime))
                .WhereIf(!string.IsNullOrWhiteSpace(req.EndTime), q => q.UpdateTime < DateTime.Parse(req.EndTime).AddDays(1));
            
            result.data = query.Skip((req.page - 1) * req.limit)
                .Take(req.limit).ToList();
            result.count = query.Count();
            
            return result;
        }

        public StaffApp(IUnitWork unitWork, IAuth auth) : base(unitWork, auth)
        {
        }
    }
}
