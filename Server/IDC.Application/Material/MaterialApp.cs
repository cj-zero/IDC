using Dapper;
using IDC.Application.Basics;
using IDC.Application.Material.Request;
using IDC.Application.Material.Response;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Material
{
    public class MaterialApp:BaseApp
    {
        public MaterialApp(IRepositoryBase repositoryBase, IAuth auth) : base(auth, repositoryBase)
        {
        }
        public async Task<TableData> GetMaterialList(QueryMaterialListReq req)
        {
            var result = new TableData();
            var sql = "select a.ItemCode,a.ItemName,a.SalUnitMsr,a.UpdateDate,a.validFrom,a.validTo,b.type_nm from store_oitm a left join store_item_type b on a.u_wlbm=b.type_id where 1=1";
            var Parameters = new DynamicParameters();
            if (!string.IsNullOrWhiteSpace(req.StartTime))
            {
                sql += " and a.UpdateDate > @StartTime"; Parameters.Add("StartTime", req.StartTime);
            }
            if (!string.IsNullOrWhiteSpace(req.EndTime))
            {
                sql += " and a.UpdateDate < @EndTime"; Parameters.Add("EndTime", DateTime.Parse(req.EndTime).AddDays(1));
            }
            result.Count = (await _repositoryBase.FindAsync<crm_ocrd>(sql, Parameters)).Count();
            Parameters.Add("Start", req.limit * (req.page - 1));
            Parameters.Add("End", req.limit);
            sql += " limit @Start,@End";
            var oitmList =(await _repositoryBase.FindAsync<store_oitm>(sql, Parameters)).Select(o=> new MaterialListResp
            {
                pt_no = o.ItemCode,
                pt_name = o.ItemCode,
                pt_desc= o.ItemName,
                pt_unit = o.SalUnitMsr,
                pt_class =o.type_nm,
                last_update_time = o.UpdateDate,
                effect_start_time=o.validFrom,
                effect_end_time=o.validTo
            }).ToList();
            oitmList.ForEach(o =>
            {
                if ((o.effect_start_time<=DateTime.Parse("0001-01-01 00:00:00") && o.effect_end_time <= DateTime.Parse("0001-01-01 00:00:00")) ||(o.effect_start_time==null && o.effect_end_time==null)) 
                {
                    o.effect_start_time = DateTime.Parse("0001-01-01 00:00:00");
                    o.effect_end_time = DateTime.Parse("9999-01-01 00:00:00");
                }
                switch (o.pt_no.Substring(0,1))
                {
                    case "C":
                        o.pt_type = "3";
                        break;
                    case "B":
                        o.pt_type = "2";
                        break;
                    case "A":
                        o.pt_type = "1";
                        break;
                    default:
                        o.pt_type = "0";
                        break;
                }
            });
            result.Data = oitmList.ToList();
            return result;
        }

    }
}
