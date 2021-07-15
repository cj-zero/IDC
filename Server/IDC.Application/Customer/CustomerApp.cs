using Dapper;
using IDC.Application.Customer.Request;
using IDC.Infrastructure.Cipher;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Customer
{
    public class CustomerApp
    {
        private readonly IRepositoryBase _repositoryBase;
        public CustomerApp(IRepositoryBase repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<TableData> GetCustomerList(QueryCustomerListReq req)
        {
            var result = new TableData();
            var sql = "select CardCode,upd_dt from crm_ocrd where 1=1";
            if (!req.IsCustomer)
            {
                sql += $" and CardType={"'S'"}";
            }
            else
            {
                sql += $" and CardType={"'C'"}";
            }
            var Parameters = new DynamicParameters();
            if (!string.IsNullOrWhiteSpace(req.StartTime))
            {
                sql += " and b.upd_dt > @StartTime"; Parameters.Add("StartTime", req.StartTime);
            }
            if (!string.IsNullOrWhiteSpace(req.EndTime))
            {
                sql += " and b.upd_dt < @EndTime"; Parameters.Add("EndTime", DateTime.Parse(req.EndTime).AddDays(1));
            }
            result.Count = (await _repositoryBase.FindAsync<crm_ocrd>(sql, Parameters)).Count();
            Parameters.Add("Start", req.limit * (req.page-1));
            Parameters.Add("End", req.limit);
            sql += " limit @Start,@End";
            var cordList = (await _repositoryBase.FindAsync<crm_ocrd>(sql, Parameters)).Select(o=>new {
                CardCode=o.CardCode,
                UpdateTime =o.upd_dt
            }).ToList();
            result.Data = cordList;
            return result;
        }
    }
}
