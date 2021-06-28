using Infrastructure.Extensions;
using OpenAuth.App.Interface;
using OpenAuth.App.Material.Request;
using OpenAuth.App.Response;
using OpenAuth.Repository.Domain;
using OpenAuth.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAuth.App.Material
{
    public class MaterialApp : OnlyUnitWorkBaeApp
    {
        public async Task<TableData> GetMaterialList(QueryMaterialListReq req)
        {
            var result = new TableData();
            var query = UnitWork.Find<store_oitm>(null)
                .WhereIf(!string.IsNullOrWhiteSpace(req.MaterialCode), s => s.ItemCode.Contains(req.MaterialCode))
                .WhereIf(!string.IsNullOrWhiteSpace(req.MaterialName), s => s.ItemName.Contains(req.MaterialName))
                .WhereIf(!string.IsNullOrWhiteSpace(req.StartTime), s => s.UpdateDate > DateTime.Parse(req.StartTime))
                .WhereIf(!string.IsNullOrWhiteSpace(req.EndTime), s => s.UpdateDate < DateTime.Parse(req.EndTime).AddDays(1))
                .Select(c => new
                {
                    MaterialCode = c.ItemCode,//编码
                    MaterialName = c.ItemName,//名称
                    MaterialUnit = c.SalUnitMsr,//单位
                    UpdateTime = c.UpdateDate,
                }).ToList();
            result.data = query.Skip((req.page - 1) * req.limit)
                .Take(req.limit);
            result.count = query.Count();
            return result;
        }

        public MaterialApp(IUnitWork unitWork, IAuth auth) : base(unitWork, auth)
        {
        }
    }
}
