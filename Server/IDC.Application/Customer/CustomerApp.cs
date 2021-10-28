using Dapper;
using IDC.Application.Basics;
using IDC.Application.Customer.Request;
using IDC.Application.SSO;
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
    public class CustomerApp : BaseApp
    {
        public CustomerApp(IRepositoryBase repositoryBase, IAuth auth) : base(auth, repositoryBase)
        {
        }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<TableData> GetCustomerList(QueryCustomerListReq req)
        {
            var result = new TableData();
            var sql = @$"select CardCode,upd_dt from crm_ocrd where sbo_id={Define.Sbo_Id}";
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
                sql += " and upd_dt >= @StartTime"; Parameters.Add("StartTime", req.StartTime);
            }
            if (!string.IsNullOrWhiteSpace(req.EndTime))
            {
                sql += " and upd_dt <= @EndTime"; Parameters.Add("EndTime", req.EndTime);
            }
            if (!string.IsNullOrWhiteSpace(req.CardName))
            {
                sql += $" and CardName  like '%{req.CardName}%' "; //Parameters.Add("CardName", req.CardName);
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
