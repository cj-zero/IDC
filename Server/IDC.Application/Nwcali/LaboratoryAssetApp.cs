using IDC.Application.Basics;
using IDC.Application.Nwcali.Request;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.AutoMapper;
using IDC.Repository.Core;
using IDC.Repository.Dapper;
using IDC.Repository.EFDbContext;
using IDC.Repository.Entities.Assets;
using IDC.Repository.Entities.Nwcali;
using IDC.Repository.Helps;
using IDC.Repository.Image;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali
{
    public class LaboratoryAssetApp : BaseApp
    {
        protected IUnitWork _unitWork;

        public LaboratoryAssetApp(IRepositoryBase repositoryBase, IAuth auth, IUnitWork unitWork) : base(auth, repositoryBase)
        {
            _unitWork = unitWork;
        }

        // <summary>
        /// 获取万用表资产信息
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<TableData> GetMultimeterAssetInfo(string sn)
        {
            TableData result = new TableData();

            var info = _unitWork.Find<LaboratoryAsset>(a => a.AssetStockNumber == sn || a.Guid == sn).FirstOrDefault();
            if (info == null)
            {
                result.Message = "请输入正确的SN/Guid编码！";
                result.Code = 500;
                return result;
            }
            var mapInfo = _unitWork.Find<PortfolioAssetsMap>(a => a.AssetId == info.Id).FirstOrDefault();
            if (mapInfo == null)
            {
                var obj = new
                {
                    asset_type = GetAssetCategoryName(info.AssetCategory),
                    asset_number = info.AssetNumber,
                    id = 0
                };
                List<object> listObj = new List<object>() { obj };
                result.Data = listObj;
            }
            else
            {
                var query = (from a in _unitWork.Find<LaboratoryAsset>(null)
                             join b in _unitWork.Find<PortfolioAssetsMap>(null) on a.Id equals b.AssetId
                             where b.PortfolioId == mapInfo.PortfolioId
                             select new
                             {
                                 asset_type = a.AssetCategory,
                                 asset_number = a.AssetNumber,
                                 id = b.Sort
                             }).ToList();
                var data = query.Select(a => new
                {
                    asset_type = GetAssetCategoryName(a.asset_type),
                    asset_number = a.asset_number,
                    id = a.id
                });
                result.Data = data.ToList();
            }
            return result;
        }

        // <summary>
        /// 获取工装资产信息
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<TableData> GetCalibrationAssetInfo(List<string> asset_number)
        {
            TableData result = new TableData();
            try
            {
                if (asset_number.Count() <= 0)
                {
                    result.Message = "请输入正确的资产编码！";
                    result.Code = 500;
                    return result;
                }

                List<LaboratoryAsset> objs = _unitWork.Find<LaboratoryAsset>(a => asset_number.Contains(a.AssetNumber)).ToList();
                var data = objs.Select(c => new {
                    asset_number = c.AssetNumber,
                    model = c.AssetStockNumber,
                    asset_AssetCalibrationCertificate = c.AssetCalibrationCertificate,                 
                    asset_type = GetAssetCategoryName(c.AssetCategory),
                    asset_type_text = c.AssetCategory,
                    assetTCF = c.AssetTCF,
                    //asset_type_text = GetAssetCategoryName(c.AssetCategory),
                    expiration_time = c.AssetEndDate,
                    asset_snapshot = GetFileContent(c.AssetTCF)
                }).ToList();

                result.Data = data;
                result.Code = 200;
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.Message;
            }
            return result;

        }

        /// <summary>
        /// 获取文本内容
        /// </summary>
        /// <param name="url">文件地址</param>
        /// <returns>返回文本字符串内容</returns>
        public string GetFileContent(string url)
        {
            string rXml = string.Empty;
            try
            {
                //正则表达式验证当前链接是否为URL链接
                string UrlFix = @"^(https?|ftp|file|ws)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
                bool urlMatch = Regex.IsMatch(url, UrlFix);
                if (urlMatch)
                {
                    HttpWebRequest myHttpWebRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;
                    myHttpWebRequest.KeepAlive = false;
                    myHttpWebRequest.AllowAutoRedirect = false;
                    myHttpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)";
                    myHttpWebRequest.Timeout = 10000;
                    myHttpWebRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                    using (HttpWebResponse res = (HttpWebResponse)myHttpWebRequest.GetResponse())
                    {
                        if (res.StatusCode == HttpStatusCode.OK || res.StatusCode == HttpStatusCode.PartialContent)//返回为200或206
                        {
                            string dd = res.ContentEncoding;
                            System.IO.Stream strem = res.GetResponseStream();
                            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                            System.IO.StreamReader r = new System.IO.StreamReader(strem, Encoding.GetEncoding("GB2312"), true);
                            rXml = r.ReadToEnd();
                        }
                    }
                }
                else
                {
                    rXml = "";
                }
               
                return rXml;
            }
            catch(Exception ex)
            {
                return "";
            }       
        }
     
        public string GetAssetCategoryName(string AssetCategory)
        {
            string str = string.Empty;
            switch (AssetCategory)
            {
                case "万用表":
                    str = "1";
                    break;
                case "工装":
                    str = "2";
                    break;
                case "分流器":
                    str = "3";
                    break;
                case "标准源":
                    str = "4";
                    break;
                default:
                    str = "";
                    break;
            }
            return str;
        }


        #region  ERP迁移
        /// <summary>
        /// 加载资产列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TableData> Load(QueryassetListReq request)
        {
           // var loginContext = _auth.GetCurrentUser();
            var result = new TableData();

            if (string.IsNullOrEmpty(request.CustomerId))
            {
                result.Code = 500;
                result.Message = "企业id不能为空!";
                return result;
            }
            var objs = _unitWork.Find<LaboratoryAsset>(a => a.CustomerId == request.CustomerId);
            if (request.isMap)
            {
                var listMap = _unitWork.Find<PortfolioAssetsMap>(a => a.SourceType == 1).Select(a => a.AssetId).ToList();
                objs = objs.Where(a => !listMap.Contains(a.Id));
            }
            var Assets = objs.WhereIf(!string.IsNullOrWhiteSpace(request.Id.ToString()), u => u.Id == request.Id).
                WhereIf(!string.IsNullOrWhiteSpace(request.AssetCategory), u => u.AssetCategory.Contains(request.AssetCategory)).
                WhereIf(!string.IsNullOrWhiteSpace(request.AssetStockNumber), u => u.AssetStockNumber.Contains(request.AssetStockNumber)).
                WhereIf(!string.IsNullOrWhiteSpace(request.AssetInspectType), u => u.AssetInspectType.Contains(request.AssetInspectType)).
                WhereIf(!string.IsNullOrWhiteSpace(request.AssetStatus), u => u.AssetStatus.Contains(request.AssetStatus)).
                WhereIf(!string.IsNullOrWhiteSpace(request.AssetType), u => u.AssetType.Contains(request.AssetType)).
                WhereIf(!string.IsNullOrWhiteSpace(request.AssetNumber), u => u.AssetNumber.Contains(request.AssetNumber)).
                WhereIf(!string.IsNullOrWhiteSpace(request.OrgName), u => u.OrgName.Contains(request.OrgName)).
                WhereIf(request.AssetStartDate != null && request.AssetEndDate != null, u => u.AssetStartDate >= request.AssetStartDate && u.AssetEndDate < Convert.ToDateTime(request.AssetEndDate).AddMinutes(1440));


            result.Data = await Assets.OrderByDescending(u => u.AssetCreateTime)
                .Skip((request.page - 1) * request.limit)
                .Take(request.limit).Select(L => new
                {
                    Id = L.Id,
                    Guid = L.Guid,
                    AssetStatus = L.AssetStatus,   //状态
                    AssetCategory = L.AssetCategory,//类别
                    OrgName = L.OrgName,//部门
                    AssetType = L.AssetType,//型号
                    AssetHolder = L.AssetHolder, // 持有者
                    AssetStockNumber = L.AssetStockNumber, // 出厂编号S/N
                    AssetAdmin = L.AssetAdmin,// 管理员
                    AssetNumber = L.AssetNumber,// 资产编号
                    AssetFactory = L.AssetFactory,        // 制造厂
                    AssetInspectType = L.AssetInspectType,       // 送检类型
                    AssetInspectWay = L.AssetInspectWay, // 送检方式
                    AssetStartDate = Convert.ToDateTime(L.AssetStartDate).ToString("yyyy-MM-dd"),// 校准日期
                    AssetCalibrationCertificate = L.AssetCalibrationCertificate,    // 校准证书
                    AssetEndDate = Convert.ToDateTime(L.AssetEndDate).ToString("yyyy-MM-dd"),     // 失效日期
                    AssetInspectDataOne = L.AssetInspectDataOne, // 校准数据1
                    AssetInspectDataTwo = L.AssetInspectDataTwo,// 校准数据2
                    AssetTCF = L.AssetTCF,// 技术文件
                    AssetDescribe = L.AssetDescribe,  // 描述
                    AssetRemarks = L.AssetRemarks,
                    AssetImage = L.AssetImage,// 备注
                    AssetCreateTime = L.AssetCreateTime,// 创建时间
                    AssetCategorys = L.LaboratoryAssetCategory != null && L.LaboratoryAssetCategory.Count > 0 ? CalculateMetrological(L.LaboratoryAssetCategory, L.AssetCategory) : ""
                }).ToListAsync();

            result.Count = Assets.Count();
            return result;
        }

        /// <summary>
        /// 计算计量特性
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="Category"></param>
        /// <returns></returns>
        public static string CalculateMetrological(List<LaboratoryAssetCategory> obj, string Category)
        {
            StringBuilder Metrological = new StringBuilder();
            foreach (var item in obj.OrderBy(u => u.CategoryAort))
            {
                Metrological.Append(item.CategoryNumber + "：");
                string symbol = "";
                if (Category.Contains("万用表"))
                {

                    if (item.CategoryNumber.Contains("DCV") || item.CategoryNumber.Contains("ACV"))
                    {
                        symbol = "V";
                    }
                    else if (item.CategoryNumber.Contains("DCI") || item.CategoryNumber.Contains("ACI"))
                    {
                        symbol = "A";
                    }
                    else if (item.CategoryNumber.Contains("OHM"))
                    {
                        symbol = "Ω";
                    }
                    if (item.CategoryType.Contains("绝对不确定度"))
                    {
                        if (!string.IsNullOrWhiteSpace(item.CategoryOhms.ToString()) && item.CategoryOhms != 0)
                        {
                            Metrological.Append("(" + Convert.ToDecimal(item.CategoryOhms).ToString("G0") + "±" + String.Format("{0:#.##########E+0}", item.CategoryNondeterminacy) + ")" + symbol + " (k=" + Convert.ToDecimal(item.CategoryBHYZ).ToString("G0") + @")\r\n");
                        }
                        else
                        {
                            Metrological.Append("±" + String.Format("{0:#.##########E+0}", item.CategoryNondeterminacy) + "" + symbol + " (k=" + Convert.ToDecimal(item.CategoryBHYZ).ToString("G0") + @")\r\n");
                        }
                    }
                    else if (item.CategoryType.Contains("相对不确定度"))
                    {
                        if (!string.IsNullOrWhiteSpace(item.CategoryOhms.ToString()) && item.CategoryOhms != 0)
                        {
                            Metrological.Append(Convert.ToDecimal(item.CategoryOhms).ToString("G0") + symbol + "，Urel=" + Convert.ToDecimal(item.CategoryNondeterminacy).ToString("G0") + "% (k=" + Convert.ToDecimal(item.CategoryBHYZ).ToString("G0") + @")\r\n");
                        }
                        else
                        {
                            Metrological.Append("Urel=" + Convert.ToDecimal(item.CategoryNondeterminacy).ToString("G0") + "% (k=" + Convert.ToDecimal(item.CategoryBHYZ).ToString("G0") + @")\r\n");
                        }
                    }
                }
                else if (Category.Contains("分流器") || Category.Contains("工装"))
                {
                    if (item.CategoryType.Contains("绝对不确定度"))
                    {
                        Metrological.Append("(" + Convert.ToDecimal(item.CategoryOhms).ToString("G0") + "±" + String.Format("{0:#.##########E+0}", item.CategoryNondeterminacy) + ")Ω (k=" + Convert.ToDecimal(item.CategoryBHYZ).ToString("G0") + @")\r\n");
                    }
                    else if (item.CategoryType.Contains("相对不确定度"))
                    {
                        Metrological.Append(Convert.ToDecimal(item.CategoryOhms).ToString("G0") + "Ω，Urel=" + Convert.ToDecimal(item.CategoryNondeterminacy).ToString("G0") + "ppm (k=" + Convert.ToDecimal(item.CategoryBHYZ).ToString("G0") + @")\r\n");
                    }
                }

            }

            return Metrological.ToString();
        }

        /// <summary>
        /// 获取失效日期大于当前时间的资产信息
        /// </summary>
        /// <returns></returns>
        public async Task<TableData> GetExpiredAssets(string categoryId)
        {
            var result = new TableData();
            //查询资产分类
            var assetCategory = await _unitWork.Find<Category>(null)
                .Where(c => c.Id == categoryId)
                .Select(x => x.Name).FirstOrDefaultAsync();

            //查询当前未过期资产
            var query = _unitWork.Find<LaboratoryAsset>(null).Where(a => a.AssetCategory == assetCategory && a.AssetEndDate > DateTime.Now).Select(a => new { a.Id, a.AssetNumber, a.AssetEndDate, CategoryName = a.AssetCategory, CategoryId = categoryId });

            result.Data = await query.ToListAsync();
            result.Count = await query.CountAsync();

            return result;
        }


        /// <summary>
        /// 查询分类列表
        /// </summary>
        /// <returns></returns>
        public async Task<TableData> GetAssetCategories(string categoryName = "")
        {
            var result = new TableData();

            var query = _unitWork.Find<Category>(null)
                .Where(c => c.TypeId == "SYS_AssetCategory")
                .WhereIf(!string.IsNullOrWhiteSpace(categoryName), c => c.Name.Contains(categoryName))
                .Select(c => new { c.Id, c.Name });

            result.Data = await query.ToListAsync();
            result.Count = await query.CountAsync();

            return result;
        }

        /// <summary>
        /// 根据id获取分类详情
        /// </summary>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        public async Task<TableData> GetAssetCategoryDetails(string categoryIds)
        {
            var result = new TableData();
            var category_ids = categoryIds.Split(",");
            var query = _unitWork.Find<Category>(null).Where(c => category_ids.Contains(c.Id));

            result.Data = await query.ToListAsync();
            result.Count = await query.CountAsync();

            return result;
        }

        /// <summary>
        /// 获取单个资产
        /// </summary>
        /// <param name="assetid"></param>
        /// <returns></returns>
        public async Task<TableData> GetAsset(int assetid)
        {
            var result = new TableData();
            var AssetModel = await _unitWork.Find<LaboratoryAsset>(u => u.Id == assetid)
                .Include(u => u.LaboratoryAssetCategory)
                .Include(u => u.LaboratoryAssetOperation)
                .Include(u => u.LaboratoryAssetInspect).FirstOrDefaultAsync();
            AssetModel.LaboratoryAssetInspect = AssetModel.LaboratoryAssetInspect.OrderByDescending(a => a.InspectCreatTime).ToList();
            AssetModel.LaboratoryAssetOperation = AssetModel.LaboratoryAssetOperation.OrderBy(a => a.OperationCreateTime).ToList();
            result.Data = AssetModel;
            return result;
        }

        /// <summary>
        /// 添加资产
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<TableData> Add(AddOrUpdateassetReq req)
        {
            var result = new TableData();
            //var obj1 = req.MapTo<Asset>();
            if (_unitWork.Find<LaboratoryAsset>(a => a.AssetStockNumber == req.AssetStockNumber).Count() > 0)
            {
                result.Message = "出厂编号重复！";
                result.Code = 500;
                return result;
            }
            
            LaboratoryAsset obj = new LaboratoryAsset();
            obj.Id = req.Id > 0 ? (int)req.Id : 0;
            obj.Guid = req.Guid;
            obj.AssetStatus = req.AssetStatus;
            obj.CustomerId = req.CustomerId;
            obj.AssetCategory = req.AssetCategory;
            obj.OrgName = req.OrgName;
            obj.AssetType = req.AssetType;
            obj.AssetHolder = req.AssetHolder;
            obj.AssetStockNumber = req.AssetStockNumber;
            obj.AssetAdmin = req.AssetAdmin;
            obj.AssetNumber = req.AssetNumber;
            obj.AssetFactory = req.AssetFactory;
            obj.AssetInspectType = req.AssetInspectType;
            obj.AssetInspectWay = req.AssetInspectWay;
            obj.AssetStartDate = req.AssetStartDate;
            obj.AssetCalibrationCertificate = req.AssetCalibrationCertificate;
            obj.AssetEndDate = req.AssetEndDate;
            obj.AssetInspectDataOne = req.AssetInspectDataOne;
            obj.AssetInspectDataTwo = req.AssetInspectDataTwo;
            obj.AssetTCF = req.AssetTCF;
            obj.AssetDescribe = req.AssetDescribe;
            obj.AssetRemarks = req.AssetRemarks;
            obj.AssetImage = req.AssetImage;
            obj.AssetCreateTime = req.AssetCreateTime;
            obj.AssetCreateUser = req.AssetCreateUser;
            obj.LaboratoryAssetCategory = new List<LaboratoryAssetCategory>();
            foreach (var item in req.laboratoryAssetCategory)
            {
                obj.LaboratoryAssetCategory.Add(new LaboratoryAssetCategory()
                {
                    LaboratoryAssetId = item.LaboratoryAssetId,
                    CategoryNumber = item.CategoryNumber,
                    CategoryOhms = item.CategoryOhms,
                    CategoryNondeterminacy = item.CategoryNondeterminacy,
                    CategoryType = item.CategoryType,
                    CategoryBHYZ = item.CategoryBHYZ,
                    CategoryAort = item.CategoryAort,
                });
            }

            //var user = _auth.GetCurrentUser();
            var account = _unitWork.Find<accounts>(a => a.status == 1 && a.passport_id == req.PassPortId).FirstOrDefault();

            var ZCNumber = "JZ" + Convert.ToInt32(req.AssetSerial).ToString("00") + DateTime.Today.ToString("yy") + DateTime.Today.ToString("MM");
            var Listasset = _unitWork.Find<LaboratoryAsset>(u => u.AssetNumber.Contains(ZCNumber)).OrderByDescending(u => u.AssetNumber).FirstOrDefault();
            if (Listasset == null)
            {
                ZCNumber += "0001";
            }
            else
            {
                var Number = Convert.ToInt32(Listasset.AssetNumber.Substring(Listasset.AssetNumber.Length - 4, 4)) + 1;
                ZCNumber += Number.ToString("0000");
            }
            obj.AssetNumber = ZCNumber;
            obj.AssetCreateTime = DateTime.Now;
            obj.AssetCreateUser = account?.realname;
            int num = 0;
            if (req.laboratoryAssetCategory != null)
            {
                req.laboratoryAssetCategory.ForEach(a => a.CategoryAort = ++num);
            }
            obj = await _unitWork.AddAsync<LaboratoryAsset, int>(obj);
            await _unitWork.SaveAsync();


            //保存第一次校准记录
            var eassetinspectReq = new LaboratoryAssetInspect();
            eassetinspectReq.LaboratoryAssetId = obj.Id;
            eassetinspectReq.InspectStartDate = obj.AssetStartDate;
            eassetinspectReq.InspectEndDate = obj.AssetEndDate;
            eassetinspectReq.InspectDataOne = obj.AssetInspectDataOne;
            eassetinspectReq.InspectDataTwo = obj.AssetInspectDataTwo;
            eassetinspectReq.InspectCertificate = obj.AssetCalibrationCertificate;
            eassetinspectReq.InspectCreatTime = DateTime.Now;
            var AssetInspectInf = await _unitWork.AddAsync<LaboratoryAssetInspect>(eassetinspectReq);
            //保存第一次操作记录
            var eassetoperationReq = new LaboratoryAssetOperation();
            eassetoperationReq.LaboratoryAssetId = obj.Id;
            eassetoperationReq.InspectId = AssetInspectInf.Id;
            eassetoperationReq.OperationContent = "创建资产成功";
            eassetoperationReq.OperationCreateTime = DateTime.Now;
            eassetoperationReq.OperationUser = account?.realname;
            await _unitWork.AddAsync<LaboratoryAssetOperation>(eassetoperationReq);
            await _unitWork.SaveAsync();
            return result;

        }

        /// <summary>
        /// 修改资产
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task Update(AddOrUpdateassetReq obj)
        {
            LaboratoryAsset model = await _unitWork.Find<LaboratoryAsset>(u => u.Id == obj.Id).FirstOrDefaultAsync();
            StringBuilder ModifyModel = new StringBuilder();
            string InspectId = null;
            bool inspect = false;
            //判断修改的数据，放到字符串中
            if (model.AssetAdmin != obj.AssetAdmin) ModifyModel.Append("管理员修改为：" + obj.AssetAdmin + @"\r\n");
            if (model.AssetDescribe != obj.AssetDescribe) ModifyModel.Append("描述修改为：" + obj.AssetDescribe + @"\r\n");
            if (model.AssetHolder != obj.AssetHolder) ModifyModel.Append("持有者修改为：" + obj.AssetHolder + @"\r\n");
            if (model.AssetRemarks != obj.AssetRemarks) ModifyModel.Append("备注修改为：" + obj.AssetRemarks + @"\r\n");
            if (model.AssetInspectType != obj.AssetInspectType) ModifyModel.Append("送检类型修改为：" + obj.AssetInspectType + @"\r\n");
            if (model.AssetStatus != obj.AssetStatus) ModifyModel.Append("状态修改为：" + obj.AssetStatus + @"\r\n");
            if (model.OrgName != obj.OrgName) ModifyModel.Append("部门修改为：" + obj.OrgName + @"\r\n");
            if (model.AssetInspectDataTwo != obj.AssetInspectDataTwo) ModifyModel.Append("修改校准数据" + @"\r\n");
            if (model.AssetStartDate != obj.AssetStartDate) ModifyModel.Append("校准日期修改为：" + obj.AssetStartDate + @"\r\n");
            if (model.AssetEndDate != obj.AssetEndDate) ModifyModel.Append("失效日期修改为：" + obj.AssetEndDate + @"\r\n");
            if (model.AssetInspectWay != obj.AssetInspectWay) ModifyModel.Append("送检方式修改为：" + obj.AssetInspectWay + @"\r\n");
            if (model.AssetImage != obj.AssetImage) ModifyModel.Append("修改图片" + @"\r\n");
            if (model.Guid != obj.Guid) ModifyModel.Append("Guid修改为" + obj.Guid + @"\r\n");
            if (model.AssetCalibrationCertificate != obj.AssetCalibrationCertificate)
            {
                ModifyModel.Append("修改校准证书" + @"\r\n");
                inspect = true;
            }

            model.Guid = obj.Guid;
            model.AssetAdmin = obj.AssetAdmin;
            model.AssetEndDate = obj.AssetEndDate;
            model.AssetStartDate = obj.AssetStartDate;
            model.AssetDescribe = obj.AssetDescribe;
            model.AssetHolder = obj.AssetHolder;
            model.AssetCalibrationCertificate = obj.AssetCalibrationCertificate;
            model.AssetInspectDataTwo = obj.AssetInspectDataTwo;
            model.AssetRemarks = obj.AssetRemarks;
            model.AssetInspectType = obj.AssetInspectType;
            model.AssetStatus = obj.AssetStatus;
            model.OrgName = obj.OrgName;
            model.AssetInspectWay = obj.AssetInspectWay;
            model.AssetImage = obj.AssetImage;
            model.AssetTCF = obj.AssetTCF;
            model.AssetInspectDataOne = obj.AssetInspectDataOne;

            _unitWork.Update(model);
            if (obj.laboratoryAssetCategory != null && obj.laboratoryAssetCategory.Count > 0)
            {
                await _unitWork.BatchUpdateAsync<LaboratoryAssetCategory>(obj.laboratoryAssetCategory.MapToList<LaboratoryAssetCategory>().ToArray());
            }
            //添加一条送检记录
            if (inspect)
            {
                var eassetinspectReq = new LaboratoryAssetInspect();
                eassetinspectReq.LaboratoryAssetId = (int)obj.Id;
                eassetinspectReq.InspectStartDate = obj.AssetStartDate;
                eassetinspectReq.InspectEndDate = obj.AssetEndDate;
                eassetinspectReq.InspectDataOne = obj.AssetInspectDataOne;
                eassetinspectReq.InspectDataTwo = obj.AssetInspectDataTwo;
                eassetinspectReq.InspectCertificate = obj.AssetCalibrationCertificate;
                eassetinspectReq.InspectCreatTime = DateTime.Now;
                var InspectModel = await _unitWork.AddAsync<LaboratoryAssetInspect>(eassetinspectReq);
                InspectId = InspectModel.Id;
            }
            //添加一条操作记录
            if (!string.IsNullOrEmpty(ModifyModel.ToString()))
            {
                var eassetoperationReq = new LaboratoryAssetOperation();
                eassetoperationReq.LaboratoryAssetId = (int)obj.Id;
                eassetoperationReq.InspectId = InspectId;
                eassetoperationReq.OperationContent = ModifyModel.ToString();
                eassetoperationReq.OperationCreateTime = DateTime.Now;

                var account = _unitWork.Find<accounts>(a => a.status == 1 && a.passport_id == obj.PassPortId).FirstOrDefault();
                //var user = _auth.GetCurrentUser();
                eassetoperationReq.OperationUser = account?.realname;
                await _unitWork.AddAsync<LaboratoryAssetOperation>(eassetoperationReq);
            }
            await _unitWork.SaveAsync();
        }


        /// <summary>
        /// 批量获取资产数据
        /// </summary>
        /// <param name="ids">资产id,存在多个id ,用因为逗号隔开 </param>
        public async Task<List<LaboratoryAsset>> GetLaboratoryAssetList(string ids)
        {
            //var idarry = ids.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var idarry = ids.Split(",");
            List<int> idList = new List<int>();
            foreach (var id in idarry)
            {
                if (id.ParseToInt() > 0)
                {
                    idList.Add(int.Parse(id));
                }
            }
            var assetList =  _unitWork.Find<LaboratoryAsset>(a => idList.Contains(a.Id)).ToList();
            return assetList;
        }


        #endregion



    }
}
