using Infrastructure.Extensions;
using OpenAuth.App.Customer.Request;
using OpenAuth.App.Interface;
using OpenAuth.App.Response;
using OpenAuth.Repository;
using OpenAuth.Repository.Domain;
using OpenAuth.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAuth.App.Customer
{
    public class CustomerApp: OnlyUnitWorkBaeApp
    {
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<TableData> GetCustomerList(QueryCustomerListReq req)
        {
            var result = new TableData();
            var query = UnitWork.Find<crm_ocrd>(null)
                .WhereIf(!string.IsNullOrWhiteSpace(req.StartTime),q=>q.upd_dt > DateTime.Parse(req.StartTime))
                .WhereIf(!string.IsNullOrWhiteSpace(req.EndTime), q => q.upd_dt < DateTime.Parse(req.EndTime).AddDays(1));
            if (!req.IsCustomer)
            {
                query = query.Where(q => q.CardType == "S");
            }
            else 
            {
                query = query.Where(q => q.CardType == "C");
            }

            var CardList= query.Select(c=>new { 
                c.CardCode,
                UpdateTime=c.upd_dt
            }).ToList();
            result.data = CardList
                .Skip((req.page - 1) * req.limit)
                .Take(req.limit);
            result.count = CardList.Count();
            return result;
        }
        public CustomerApp(IUnitWork unitWork, IAuth auth) : base(unitWork, auth)
        {
        }
    }
}
