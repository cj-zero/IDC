using Dapper;
using IDC.Application.Basics;
using IDC.Application.Material.Request;
using IDC.Application.Material.Response;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBone;
using IDC.Repository.Entities.VMS;
using IDC.Repository.Entities.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Material
{
    public class MaterialApp : BaseApp
    {
        public MaterialApp(IRepositoryBase repositoryBase, IAuth auth) : base(auth, repositoryBase)
        {
        }
        public async Task<TableData> GetMaterialList(QueryMaterialListReq req)
        {
            var result = new TableData();
            var sql = @$"select a.ItemCode,a.ItemName,a.SalUnitMsr,a.UpdateDate,a.validFrom,a.validTo,b.type_nm from store_oitm a left join store_item_type b on a.u_wlbm=b.type_id where a.sbo_id={Define.Sbo_Id}";
            var Parameters = new DynamicParameters();
            if (!string.IsNullOrWhiteSpace(req.StartTime))
            {
                sql += " and a.UpdateDate >= @StartTime"; Parameters.Add("StartTime", req.StartTime);
            }
            if (!string.IsNullOrWhiteSpace(req.EndTime))
            {
                sql += " and a.UpdateDate <= @EndTime"; Parameters.Add("EndTime", req.EndTime);
            }
            result.Count = (await _repositoryBase.FindAsync<store_oitm>(sql, Parameters)).Count();
            Parameters.Add("Start", req.limit * (req.page - 1));
            Parameters.Add("End", req.limit);
            sql += " limit @Start,@End";
            var oitmList = (await _repositoryBase.FindAsync<store_oitm>(sql, Parameters)).Select(o => new MaterialListResp
            {
                pt_no = o.ItemCode,
                pt_name = o.ItemCode,
                pt_desc = o.ItemName,
                pt_unit = o.SalUnitMsr,
                pt_class = o.type_nm,
                last_update_time = o.UpdateDate,
                effect_start_time = o.validFrom,
                effect_end_time = o.validTo
            }).ToList();
            oitmList.ForEach(o =>
            {
                if ((o.effect_start_time <= DateTime.Parse("0001-01-01 00:00:00") && o.effect_end_time <= DateTime.Parse("0001-01-01 00:00:00")) || (o.effect_start_time == null && o.effect_end_time == null))
                {
                    o.effect_start_time = DateTime.Parse("0001-01-01 00:00:00");
                    o.effect_end_time = DateTime.Parse("9999-01-01 00:00:00");
                }
                switch (o.pt_no.Substring(0, 1))
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

        /// <summary>
        /// 根据设备guid获取中位机软件版本
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<TableData> GetZWJSoftwareVersion(string guid)
        {
            var result = new TableData();
            //根据guid查找序列号
            var sql = "select sn,dev_type from dev_binding_info where dev_guid = @guid";
            var parameters = new DynamicParameters();
            parameters.Add("guid", guid);
            var bindingData = await _repositoryBase.FindAsync<BindingInfo>(sql, parameters);
            var sn = bindingData?.FirstOrDefault()?.sn;
            if (string.IsNullOrEmpty(sn))
            {
                throw new Exception("该设备guid在设备绑定信息表中不存在.");
            }
            if (bindingData.FirstOrDefault()?.dev_type != 2)
            {
                throw new Exception("该设备guid不属于中位机.");
            }

            #region 待规则确认
            //去除头尾
            //var head = sn.IndexOf('_');
            //var tail = sn.LastIndexOf('_');
            //var snQuery = sn.Substring(0, tail).Substring(head + 1);

            ////根据序列号查询软件版本号
            //var sql1 = @"select s.ZWJSoftwareVersionName,s.FilePath
            //            from zwjhardware as h
            //            join zwjsoftwareversion as s
            //            on h.ZWJSoftwareVersionId = s.Id
            //            where h.ZWJSn like @zwjSn";
            //var parameters1 = new DynamicParameters();
            //parameters1.Add("zwjSn", $"%{snQuery}%");
            //var versionData = await _repositoryBase.FindAsync<ZWJSoftwareVersion>(sql1, parameters1);
            //result.Data = new
            //{
            //    ver = versionData.FirstOrDefault()?.ZWJSoftwareVersionName,
            //    dl_url = versionData.FirstOrDefault()?.FilePath
            //};
            #endregion

            result.Data = new
            {
                ver = "4S_2.12.7.12_20210526_140800",
                dl_url = "https://erp4.obs.cn-south-1.myhuaweicloud.com/bts-rom/4S_2.12.7.12_20210526_140800.zip"
            };

            return result;
        }

        /// <summary>
        /// 根据设备guid获取下位机软件版本
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<TableData> GetXWJSoftwareVersion(string guid)
        {
            var result = new TableData();
            //根据guid查找序列号
            var sql = "select sn,dev_type from dev_binding_info where dev_guid = @guid";
            var parameters = new DynamicParameters();
            parameters.Add("guid", guid);
            var data = await _repositoryBase.QueryFirstAsync<BindingInfo>(sql, parameters);
            var sn = data?.sn;
            if (string.IsNullOrEmpty(sn))
            {
                throw new Exception("该设备guid在设备绑定信息表中不存在.");
            }
            if (data.dev_type != 1)
            {
                throw new Exception("该设备guid不属于下位机.");
            }

            #region 待规则确认
            //去除头尾
            //var head = sn.IndexOf('_');
            //var tail = sn.LastIndexOf('_');
            //var snQuery = sn.Substring(0, tail).Substring(head + 1);

            ////根据序列号查询软件版本号
            //var sql1 = @"select s.XWJSoftwareVersionName,s.FilePath
            //            from xwjhardware as h
            //            join xwjsoftwareversion as s
            //            on h.Alias = s.Alias
            //            where h.XWJSn like @xwjSn";
            //var parameters1 = new DynamicParameters();
            //parameters1.Add("xwjSn", $"%{snQuery}%");
            //var versionData = await _repositoryBase.QueryFirstAsync<XWJSoftwareVersion>(sql1, parameters1);
            //result.Data = new
            //{
            //    ver = versionData.XWJSoftwareVersionName,
            //    dl_url = versionData.FilePath
            //};
            #endregion

            result.Data = new
            {
                ver = "XWJ7S_4.3.1.0_20210527_093433_8Ch_2AR",
                dl_url = "https://erp4.obs.cn-south-1.myhuaweicloud.com/bts-rom/XWJ7S_4.3.1.0_20210527_093433_8Ch_2AR.bin",
            };

            return result;
        }

    }
}
