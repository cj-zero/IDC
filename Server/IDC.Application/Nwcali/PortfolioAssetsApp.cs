using IDC.Application.Basics;
using IDC.Application.Nwcali.Request;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Core;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.Assets;
using IDC.Repository.Entities.Nwcali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali
{
    public class PortfolioAssetsApp : BaseApp
    {
        protected IUnitWork _unitWork;

        public PortfolioAssetsApp(IRepositoryBase repositoryBase, IAuth auth, IUnitWork unitWork) : base(auth, repositoryBase)
        {
            _unitWork = unitWork;
        }

        /// <summary>
        /// 加载组合资产列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TableData> Load(QueryPortfolioAssetListReq request)
        {
            var result = new TableData();

            if (string.IsNullOrEmpty(request.CustomerId))
            {
                result.Code = 500;
                result.Message = "企业id不能为空!";
                return result;
            }
            var objs = _unitWork.Find<PortfolioAssets>(a => a.CustomerId == request.CustomerId);
            var Assets = objs.WhereIf(!string.IsNullOrWhiteSpace(request.AssetsId), u => u.Guid == request.AssetsId).
                WhereIf(!string.IsNullOrWhiteSpace(request.Name), u => u.Name.Contains(request.Name)).
                WhereIf(request.Category > 0, u => u.Category == request.Category).
                WhereIf(request.FirmwareParts > 0, u => u.FirmwareParts == request.FirmwareParts).
                WhereIf(request.TemporaryParts > 0, u => u.TemporaryParts == request.TemporaryParts).
                WhereIf(!string.IsNullOrWhiteSpace(request.CreateUser), u => u.CreateUser == request.CreateUser).
                WhereIf(!string.IsNullOrWhiteSpace(request.OrgName), u => u.CreateUser == request.OrgName).
                WhereIf(request.CreateStartTime != null, u => u.CreateTime >= request.CreateStartTime).
                WhereIf(request.CreateEndTime != null, u => u.CreateTime < request.CreateEndTime).
                WhereIf(request.UpdateStartTime != null, u => u.UpdateTime >= request.UpdateStartTime).
                WhereIf(request.UpdateEndTime != null, u => u.UpdateTime < request.UpdateEndTime);

            result.Data = Assets.OrderByDescending(u => u.CreateTime)
                .Skip((request.page - 1) * request.limit)
                .Take(request.limit).ToList();
            result.Count = Assets.Count();
            return result;
        }

        /// <summary>
        /// 加载组合资产详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TableData> GetDetails(int Id)
        {
            var result = new TableData();
            var info = _unitWork.Find<PortfolioAssets>(a => a.Id == Id).First();
            var mapList = _unitWork.Find<PortfolioAssetsMap>(a => a.PortfolioId == Id).ToList();

            var laboratoryIds = mapList.Where(a => a.SourceType == 1).Select(a => a.AssetId).ToList();
            var laboratoryList = _unitWork.Find<LaboratoryAsset>(a => laboratoryIds.Contains(a.Id))
                .Select(a => new PartsInfo
                {
                    Id = a.Id,
                    Category = a.AssetCategory,
                    //Name =  a.,
                    AssetType = a.AssetType,
                    Sn = a.AssetStockNumber,
                    AssetNumber = a.AssetNumber,
                    SourceType = 1
                }).ToList();

            var assetsIds = mapList.Where(a => a.SourceType == 2).Select(a => a.AssetId).ToList();
            var assetsList = _unitWork.Find<assets>(a => assetsIds.Contains(a.id)).ToList();
            var assets_list_category_ids = assetsList.Select(a => a.category_id).ToList();
            var category_list = _unitWork.Find<assets_category>(c => assets_list_category_ids.Contains(c.id) && c.status == 1).Select(c => new { c.name, c.id }).ToList();
            var totalAssetsList = assetsList.Select(a => new PartsInfo
            {
                Id = a.id,
                Category = category_list.Where(c => c.id == a.category_id).FirstOrDefault()?.name,//类别名称
                Name = a.name,
                AssetType = a.spec_no,
                Sn = a.sn,
                AssetNumber = a.assets_no,//资产编号
                SourceType = 2
            }).ToList();


            var fixedLaboratoryId = mapList.Where(a => a.SourceType == 1 && a.PartsType == 1).Select(a => a.AssetId).ToList();//固定实验室
            var fixedassetsId = mapList.Where(a => a.SourceType == 2 && a.PartsType == 1).Select(a => a.AssetId).ToList();//固定普通

            var temporaryLaboratoryId = mapList.Where(a => a.SourceType == 1 && a.PartsType == 2).Select(a => a.AssetId).ToList();//临时实验室
            var temporaryAssetsId = mapList.Where(a => a.SourceType == 2 && a.PartsType == 2).Select(a => a.AssetId).ToList();//临时普通

            var FirmwareList = new List<PartsInfo>();
            FirmwareList.AddRange(laboratoryList.Where(a => fixedLaboratoryId.Contains(a.Id)).ToList());
            FirmwareList.AddRange(totalAssetsList.Where(a => fixedassetsId.Contains(a.Id)).ToList());

            var TemporaryList = new List<PartsInfo>();
            TemporaryList.AddRange(laboratoryList.Where(a => temporaryLaboratoryId.Contains(a.Id)).ToList());
            TemporaryList.AddRange(totalAssetsList.Where(a => temporaryAssetsId.Contains(a.Id)).ToList());

            result.Data = new
            {

                info = info,
                FirmwareInfo = FirmwareList,
                TemporaryInfo = TemporaryList,
            };
            return result;
        }
        /// <summary>
        /// 添加/修改组合资产
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Infrastructure.Returned.Response> AddOrUpdate(AddOrUpdatePortfolioAssetsReq req)
        {
            var result = new Infrastructure.Returned.Response();
            if (req.PassPortId <= 0)
            {
                result.Code = 500;
                result.Message = "用户id不能为空!";
                return result;
            }
            var user = _unitWork.Find<accounts>(a => a.passport_id == req.PassPortId).FirstOrDefault();
            int id = 0;
            if (req.Id > 0)
            {
                id = (int)req.Id;
                var info = _unitWork.Find<PortfolioAssets>(a => a.Id == req.Id).First();
                info.Name = req.Name;
                info.Category = req.Category;
                info.FirmwareParts = req.FirmwareInfo.Count();
                info.TemporaryParts = req.TemporaryInfo.Count();
                info.OrgName = req.OrgName;
                info.Remark = req.Remark;
                info.UpdateTime = DateTime.Now;
                await _unitWork.UpdateAsync(info);

                var mapList = _unitWork.Find<PortfolioAssetsMap>(a => a.PortfolioId == req.Id).ToList();
                await _unitWork.BatchDeleteAsync(mapList.ToArray());
            }
            else
            {
                PortfolioAssets info = new PortfolioAssets();
                info.Guid = req.Guid;
                info.Name = req.Name;
                info.Category = req.Category;
                info.FirmwareParts = req.FirmwareInfo.Count();
                info.TemporaryParts = req.TemporaryInfo.Count();
                info.OrgName = req.OrgName;
                info.Remark = req.Remark;
                info.CreateTime = DateTime.Now;
                info.UpdateTime = DateTime.Now;
                info.CreateUser = user?.realname;
                info.CreateUserId = user?.passport_id.ToString();
                info.CustomerId = req.CustomerId;
                var obj = await _unitWork.AddAsync<PortfolioAssets, int>(info);
                await _unitWork.SaveAsync();
                id = obj.Id;
            }

            foreach (var item in req.FirmwareInfo)
            {
                PortfolioAssetsMap map = new PortfolioAssetsMap();
                map.PortfolioId = id;
                map.AssetId = item.AssetId;
                map.SourceType = item.SourceType;
                map.PartsType = item.PartsType;
                map.Sort = item.Sort;
                await _unitWork.AddAsync<PortfolioAssetsMap, int>(map);
            }
            await _unitWork.SaveAsync();
            foreach (var item in req.TemporaryInfo)
            {
                PortfolioAssetsMap map = new PortfolioAssetsMap();
                map.PortfolioId = id;
                map.AssetId = item.AssetId;
                map.SourceType = item.SourceType;
                map.PartsType = item.PartsType;
                map.Sort = item.Sort;
                await _unitWork.AddAsync<PortfolioAssetsMap, int>(map);
            }
            await _unitWork.SaveAsync();
            return result;
        }


        /// <summary>
        /// 删除组合资产
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task Delete(int Id)
        {
            var info = _unitWork.Find<PortfolioAssets>(a => a.Id == Id).First();
            var mapList = _unitWork.Find<PortfolioAssetsMap>(a => a.PortfolioId == Id).ToList();
            await _unitWork.DeleteAsync(info);
            if (mapList.Count() > 0)
            {
                await _unitWork.BatchDeleteAsync(mapList.ToArray());
            }
            await _unitWork.SaveAsync();
        }
        public class PartsInfo
        {

            public int Id { get; set; }
            public string Category { get; set; }
            public string Name { get; set; }
            public string AssetType { get; set; }
            public string Sn { get; set; }
            public string AssetNumber { get; set; }
            public int SourceType { get; set; }

            //a.AssetType,
            //a.AssetStockNumber,
            //a.AssetNumber,
            //a.OrgName


            //a.guid,
            //a.sn,
            //a.brand,
            //a.spec_no,
            //a.assets_no


        }
    }
}
