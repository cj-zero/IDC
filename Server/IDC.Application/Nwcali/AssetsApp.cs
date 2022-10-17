using IDC.Application.Basics;
using IDC.Application.Nwcali.Request;
using IDC.Application.Nwcali.Response;
using IDC.Application.SSO;
using IDC.Infrastructure.Redis;
using IDC.Infrastructure.Returned;
using IDC.Repository.AutoMapper;
using IDC.Repository.Core;
using IDC.Repository.Dapper;
using IDC.Repository.EFDbContext;
using IDC.Repository.Entities.Assets;
using IDC.Repository.Entities.Nwcali;
using IDC.Repository.Helps;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace IDC.Application.Nwcali
{
    public class AssetsApp : BaseApp
    {
        protected IUnitWork _unitWork;

        public IConfiguration Configuration { get; }
        public AssetsApp(IRepositoryBase repositoryBase, IAuth auth, IUnitWork unitWork, IConfiguration configuration) : base(auth, repositoryBase)
        {
            _unitWork = unitWork;

        }


        #region 普通资产

        /// <summary>
        /// 资产列表(web)
        /// </summary>
        /// <param name="key">模糊查询值（默认空值） </param>
        /// <param name="purchase_order_no">采购订单号 （默认0）</param>
        /// <param name="category_id">资产类型ID  (默认0 全部资产类型)</param>
        /// <param name="room_id">实验室id (默认0 全部实验室) </param>
        /// <param name="status">状态 -1 全部（默认） 0-禁用 1-闲置 2-使用中 3-维修中 4-报废  5-已转储 </param>
        /// <param name="guarantee_period_end">保修期区间 结束时间 （如 1990-01-02）  默认空字符串 </param>
        /// <param name="PageCount">页数据量</param>
        /// <param name="PageIndex">页码</param>
        /// <param name="is_show">是否在资产列表显示 0:否  1:是（默认）</param>

        public async Task<TableData> AssetsList(string key = "", int purchase_order_no = 0, int category_id = 0, int room_id = 0, int status = -1,
            string guarantee_period_end = "", int PageCount = 20, int PageIndex = 1, int is_show = 1, bool isMap = false, string customer_id = "")
        {
            TableData apiResult = new TableData();
            // 全部资产
            var assets_counts = 0;
            // 全部页数
            var page_counts = 0;
            var current_page = PageIndex;
            var guarantee_period_start = string.Empty;
            if (!string.IsNullOrEmpty(guarantee_period_end))
            {
                // 检查时间格式 && end > 当前时间
                DateTime check_end_time;
                var is_effective_end_time = DateTime.TryParse(guarantee_period_end, out check_end_time);
                if (is_effective_end_time)
                {
                    if (check_end_time < DateTime.Now)
                    {
                        apiResult.Message = "保修时间不得小于当前时间！";
                        apiResult.Code = 500;
                        return apiResult;
                    }
                    else
                    {   // guarantee_period_end 有效，guarantee_period_start 为当前时间
                        guarantee_period_start = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                }
                else
                {
                    apiResult.Message = "保修时间输入有误！";
                    apiResult.Code = 500;
                    return apiResult;
                }

            }
            //var UserData = _auth.GetCurrentUser();
            List<dynamic> asset_list = new List<dynamic>();
            var allAssets = GetAssetsList(customer_id, room_id, category_id, status, guarantee_period_start, guarantee_period_end, key, purchase_order_no, is_show, isMap);

            assets_counts = allAssets.Count();
            if (assets_counts > 0)
            {
                page_counts = (int)Math.Ceiling((double)assets_counts / PageCount);
                //对分页的数据进行字段补充
                allAssets = allAssets.Skip(PageCount * (PageIndex - 1)).Take(PageCount).ToList();

                var userDic = AssetUser(allAssets);
                var roomDic = AssetRoom(allAssets);

                var allCategorys = GetAllAssetsCategory(customer_id);
                foreach (var item in allAssets)
                {
                    var category_name = allCategorys.Where(c => c.id == item.category_id).FirstOrDefault()?.name;
                    var user = userDic.ContainsKey(item.id) ? userDic[item.id] : "";
                    var roomInfo = roomDic.ContainsKey(item.id) ? roomDic[item.id] : null;
                    var status_txt = ConvertAssetStatus(item.status);
                    var book_id = 0;
                    var over_time = string.Empty;
                    var start_time = string.Empty;

                    if (item.status == 2 && (item.use_type == 2 || item.use_type == 1))
                    {
                        var book = GetCurrentBook(item.id, item.use_type);
                        if (book != null)
                        {
                            book_id = book.id;
                            over_time = book.over_time.ToString("yyyy-MM-dd HH:mm");
                            start_time = book.start_time.ToString("yyyy-MM-dd HH:mm");
                        }
                    }

                    var use_type_txt = string.Empty;
                    switch (item.use_type)
                    {
                        case 1:
                            use_type_txt = "借用";
                            break;
                        case 2:
                            use_type_txt = "预约";
                            break;
                        case 3:
                            use_type_txt = "领用";
                            break;
                        default:
                            break;
                    }
                    dynamic new_asset = new
                    {
                        item.id,
                        item.assets_no,//资产编号
                        item.name,//资产名称
                        item.sn,
                        item.guid,
                        item.cover_img,//图片
                        item.category_id,//类别ID
                        category_name,//类别名称
                        item.brand,//品牌
                        item.spec_no,//型号
                        item.serial,//数量
                        item.unit,//单位
                        item.color,//颜色
                        item.purchase_order_no,//采购订单号
                        room = roomInfo == null ? "" : roomInfo.name,//实验室
                        room_id = roomInfo == null ? 0 : roomInfo.room_id,//实验室id
                        item.status,
                        status_txt,//状态
                        user,//当前使用人
                        item.use_type,
                        use_type_txt,//使用类型
                        item.item_code,//物料编码
                        item.place,//存放地点
                        item.item_code_dscription,//物料描述
                        item.is_bts,//是否bts设备
                        created_on = item.created_on.ToString("yyyy-MM-dd HH:mm"),//创建时间
                        start_time,//预约开始时间
                        over_time,//预约结束时间
                        book_id,//预约id
                        remark = item.remark == null ? "" : item.remark,//备注
                        guarantee_period = item.guarantee_period?.ToString("yyyy-MM-dd HH:mm"),//保修期
                        purchase_date = item.purchase_date?.ToString("yyyy-MM-dd HH:mm")//采购时间
                    };
                    asset_list.Add(new_asset);
                }
            }
            dynamic result_info = new { assets_counts, current_page, page_counts, asset_list };
            apiResult.Data = result_info;
            return apiResult;
        }

        /// <summary>
        /// 获取正在使用的资产对应的当前申请单
        /// </summary>
        /// <param name="assetsList"></param>
        /// <returns></returns>
        public assets_book GetCurrentBook(int assets_id, int use_type)
        {

            if (use_type == 2)
            {
                return _unitWork.Find<assets_book>(b => b.assets_id == assets_id
                && b.status == 1
                && b.audit_status == 1
                && b.start_time < DateTime.Now
                && b.over_time > DateTime.Now).FirstOrDefault();
            }
            else
            {
                return _unitWork.Find<assets_book>(b => b.assets_id == assets_id
                && b.status == 1
                && b.audit_status == 1
               ).OrderByDescending(c => c.create_time).FirstOrDefault();
            }
        }
        public string ConvertAssetStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return "禁用";
                case 1:
                    return "闲置";
                case 2:
                    return "使用中";
                case 3:
                    return "维修中";
                case 4:
                    return "报废";
                case 5:
                    return "已转储";
                default:
                    return "";
            }
        }
        public Dictionary<int, room> AssetRoom(List<assets> assetsList)
        {

            var dic = new Dictionary<int, room>();
            var all_room_map = (from m in _unitWork.Find<assets_room_map>(null)
                                join r in _unitWork.Find<room>(a => a.create_source == 1) on m.room_id equals r.room_id
                                select new { r.room_id, r.name, m.assets_id }).ToList();

            foreach (var assets in assetsList)
            {
                var room = all_room_map.Where(r => r.assets_id == assets.id).FirstOrDefault();
                if (room == null)
                    continue;

                var model = new room();
                model.room_id = room.room_id;
                model.name = room.name;
                dic.Add(assets.id, model);
            }
            return dic;
        }
        /// <summary>
        /// 获取资产的当前使用人信息
        /// </summary>
        /// <param name="assets"></param>
        /// <returns></returns>
        public Dictionary<int, string> AssetUser(List<assets> assetsList)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            var users = _unitWork.Find<accounts>(null).ToList();


            var all_assets_books = _unitWork.Find<assets_book>(l => l.audit_status == 1 && l.status == 1).OrderByDescending(l => l.create_time).ToList();
            var all_return_logs = _unitWork.Find<assets_return_log>(null).ToList();
            foreach (var assets in assetsList)
            {
                int useType = assets.use_type;
                int assetsId = assets.id;
                if (useType == 1)
                {
                    var useLog = all_assets_books.Where(l => l.assets_id == assetsId && l.has_returned == 0 && l.audit_status == 1 && l.status == 1).OrderByDescending(l => l.create_time).FirstOrDefault();
                    if (useLog == null)
                    {
                        dic.Add(assetsId, "无");
                        continue;
                    }
                    var returnLog = all_return_logs.Where(l => l.rel_id == useLog.id).FirstOrDefault();
                    if (returnLog != null)
                    {
                        dic.Add(assetsId, "无");
                        continue;
                    }
               
                    var user = users.Where(u => u.passport_id == useLog.passport_id).FirstOrDefault();
                    if (user == null)
                    {
                        dic.Add(assetsId, "无");
                        continue;
                    }
                    else
                    {
                        var dep = "";// string.IsNullOrWhiteSpace(user.department) == true ? "" : user.department + "-";
                        string name = string.IsNullOrWhiteSpace(user.realname) == true ? user.nickname : dep + user.realname;
                        dic.Add(assetsId, name);
                    }
                }
                else
                {
                    var book = all_assets_books.Where(b => b.assets_id == assetsId && b.start_time < DateTime.Now && b.over_time > DateTime.Now && b.status == 1 && b.audit_status == 1).FirstOrDefault();
                    if (book == null)
                    {
                        dic.Add(assetsId, "无");
                        continue;
                    }
                    var user = users.Where(u => u.passport_id == book.passport_id).FirstOrDefault();
                    if (user == null)
                    {
                        dic.Add(assetsId, "无");
                        continue;
                    }
                    else
                    {
                        var dep = "";//string.IsNullOrWhiteSpace(user.department) == true ? "" : user.department + "-";
                        string name = string.IsNullOrWhiteSpace(user.realname) == true ? user.nickname : dep + user.realname;
                        dic.Add(assetsId, name);
                    }
                }
            }
            return dic;
        }

        /// <summary>
        /// 资产列表(web)
        /// </summary>
        /// <param name = "customer_code" > 客户代码 </ param >
        /// <param name="room_id">实验室id </param>
        /// <param name="category_id">资产类型id </param>
        /// <param name="status">状态 -1 全部（默认） 0-禁用 1-闲置 2-使用中 3-维修中 4-报废  5-已转储 </param>
        /// <param name="guarantee_period_start">保修期区间条件查询 开始时间 （如 1990-01-01）  </param>
        /// <param name="guarantee_period_end">保修期区间 介绍时间 （如 1990-01-02）  </param>
        /// <param name="key">模糊查询值 </param>
        /// <param name="purchase_order_no">采购订单号 </param>
        /// <param name="is_show">是否在资产列表显示</param>
        public List<assets> GetAssetsList(string customer_id, int room_id, int category_id, int status, string guarantee_period_start, string guarantee_period_end, string key, int purchase_order_no, int is_show = 1, bool isMap = false)
        {

            List<assets> assets_list = new List<assets>();
            var total_asssets = _unitWork.Find<assets>(c => c.customer_id == customer_id && c.is_private == false && c.is_delete == false).ToList();

            if (isMap)
            {
                var list = _unitWork.Find<PortfolioAssetsMap>(a => a.SourceType == 2).Select(a => a.AssetId).ToList();
                total_asssets = total_asssets.Where(a => !list.Contains(a.id)).ToList();
            }

            if (is_show == 1)
                total_asssets = total_asssets.Where(c => c.is_show == true).ToList();
            else
                total_asssets = total_asssets.Where(c => c.is_show == false).ToList();

            if (!string.IsNullOrEmpty(guarantee_period_end) && !string.IsNullOrEmpty(guarantee_period_start))
            {
                var warranty_start = DateTime.Parse(guarantee_period_start);
                var warranty_end = DateTime.Parse(guarantee_period_end);
                warranty_end = warranty_end.AddDays(1);
                total_asssets = total_asssets.Where(c => c.guarantee_period >= warranty_start && c.guarantee_period <= warranty_end).ToList();
            }

            if (purchase_order_no != 0)
            {
                total_asssets = total_asssets.Where(c => c.purchase_order_no == purchase_order_no).ToList();
            }

            if (room_id > 0)
            {
                var total_assets_room_map = (from rm in _unitWork.Find<assets_room_map>(null)
                                             join r in _unitWork.Find<room>(a => a.status == 1 && a.create_source == 1) on rm.room_id equals r.room_id
                                             where (r.customer_id == customer_id || r.room_id == 99)
                                             select new { r.room_id, r.name, rm.assets_id }).ToList();
                total_assets_room_map = total_assets_room_map.Where(c => c.room_id == room_id).ToList();
                var map_room_assets_ids = total_assets_room_map.Select(c => c.assets_id).ToList();
                total_asssets = total_asssets.Where(c => map_room_assets_ids.Contains(c.id)).ToList();
            }
            if (category_id > 0)
            {
                List<int> category_list = new List<int>();
                var all_category_ids = GetAssetsCategoryIDLists(customer_id, category_id);
                category_list.AddRange(all_category_ids);
                total_asssets = total_asssets.Where(c => category_list.Contains(c.category_id)).ToList();
            }

            if (!string.IsNullOrEmpty(key))
            {
                try
                {
                    key = TextHelper.DelHTML(key);
                    key = key.Trim();
                    key = key.Replace("^", string.Empty).Replace("$", string.Empty);
                    if (key.IndexOf("*") == 0)
                        key = key.Substring(1, key.Length - 1);
                    var expression = @"^.*" + key + ".*$";
                    expression = expression.ToUpper();
                    var test_flag = Regex.IsMatch("TEST", expression);
                    total_asssets = total_asssets.Where(u => Regex.IsMatch(u.name.ToUpper(), expression)
                               || (u.assets_no != null && Regex.IsMatch(u.assets_no.ToUpper(), expression))
                               || (u.guid != null && Regex.IsMatch(u.guid.ToUpper(), expression))
                               || (u.brand != null && Regex.IsMatch(u.brand.ToUpper(), expression))
                               || (u.spec_no != null && Regex.IsMatch(u.spec_no.ToUpper(), expression))
                               || (u.sn != null && Regex.IsMatch(u.sn.ToUpper(), expression))
                     ).ToList();
                }
                catch (Exception ex)
                {
                    //total_asssets = new List<assets>();
                }
            }
            DateTime dt = DateTime.Now;
            var allBookInfo = (from a in _unitWork.Find<assets_book>(a => a.status == 1)
                               join b in _unitWork.Find<assets>(a => a.is_private == false && a.is_delete == false && a.customer_id == customer_id) on a.assets_id equals b.id
                               select a).ToList();//预约类型资产有效申请单

            // 预约类型闲置（包括闲置+使用中）,需要重新区分
            var idels_book_assets = total_asssets.Where(c => c.use_type == 2).ToList();
            foreach (var item in idels_book_assets)
            {
                if (item.status == 1 || item.status == 2)
                {
                    var hasBooks = allBookInfo.Where(c => c.use_type == 2 && c.assets_id == item.id && c.start_time <= dt && c.over_time >= dt && c.status == 1 && c.audit_status == 1).OrderByDescending(c => c.id).FirstOrDefault();
                    if (hasBooks != null)
                        item.status = 2;
                    else
                        item.status = 1;

                    assets_list.Add(item);
                }
                else
                {
                    assets_list.Add(item);
                }
            }
            var other_assets = total_asssets.Except(idels_book_assets).ToList();
            // 重新整合有效的资产数据
            assets_list.AddRange(other_assets);

            if (status >= 0)
            {
                assets_list = assets_list.Where(c => c.status == status).ToList();
            }
            assets_list = assets_list.OrderByDescending(c => c.id).ToList();
            return assets_list;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer_code">客户代码</param>
        /// <param name="room_id">实验室id</param>
        /// <param name="category_id">资产类型id</param>
        /// <param name="status">状态 -1 全部（默认） 0-禁用 1-闲置 2-使用中 3-维修中 4-报废  5-已转储</param>
        /// <param name="guarantee_period_end">保修期</param>
        /// <param name="key">模糊查询值</param>
        /// <param name="purchase_order_no">采购订单号</param>
        /// <param name="user_name">使用人名称</param>
        /// <param name="PageCount"></param>
        /// <param name="PageIndex"></param>
        /// <param name="is_show">是否在资产列表显示</param>
        /// <returns></returns>
        public async Task<TableData> AssetsList2(string customer_code, int room_id, int category_id, int status, DateTime? guarantee_period_end, string key, int purchase_order_no, string user_name, int PageCount, int PageIndex, int is_show = 1)
        {
            TableData serviceResult = new TableData();
            List<object> list = new List<object>();
            DateTime dt = DateTime.Now;
            var is_show_identity = is_show == 1 ? true : false;
            var query = _unitWork.Find<assets>(c => c.customer_code == customer_code && c.is_private == false && c.is_delete == false && c.is_show == is_show_identity);
            List<int> category_ids = new List<int>();
            if (category_id > 0)
            {
                category_ids = GetAssetsCategoryIDLists(customer_code, category_id);
            }
            List<int> room_assets_ids = new List<int>();
            if (room_id > 0)
            {
                room_assets_ids = _unitWork.Find<assets_room_map>(c => c.room_id == room_id).Select(c => c.assets_id).ToList();
            }
            List<int> assets_ids = new List<int>();
            if (status != -1)
            {
                switch (status)
                {
                    case 0:
                    case 3:
                    case 4:
                    case 5:
                        assets_ids = query.Where(c => c.status == status && c.use_type == 2).Select(c => c.id).ToList();
                        break;
                    case 1:
                        var using_assets = _unitWork.Find<assets_book>(c => c.audit_status == 1 && c.status == 1 && c.use_type == 2 && c.start_time <= dt && c.over_time >= dt).Select(c => c.assets_id).ToList();
                        assets_ids = query.Where(c => c.use_type == 2 && !using_assets.Contains(c.id) && (c.status == 1 || c.status == 2)).Select(c => c.id).ToList();
                        break;
                    case 2:
                        var using_assets_ids = _unitWork.Find<assets_book>(c => c.audit_status == 1 && c.status == 1 && c.use_type == 2 && c.start_time <= dt && c.over_time >= dt).Select(c => c.assets_id).ToList();
                        assets_ids = query.Where(c => c.use_type == 2 && using_assets_ids.Contains(c.id) && (c.status == 1 || c.status == 2)).Select(c => c.id).ToList();
                        break;
                }
            }
            //使用人
            List<int> use_assets_ids = new List<int>();
            if (!string.IsNullOrWhiteSpace(user_name) && customer_code == "C00550")
            {
                string xtoken = string.Empty;
                var token_res = GetXToken();
                if (token_res.Code ==500)
                    xtoken = "";
                else
                    xtoken = token_res.Data.ToString();
                string url = Configuration.GetSection("ERP4Url").Value + "ErpAppApi/LuckDraw/AppUserList";
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("user_ids", new List<int> { });
                dic.Add("key", user_name);
                dic.Add("page_index", 0);
                dic.Add("page_size", 0);
                string res = HttpsPost(url, JsonConvert.SerializeObject(dic), xtoken);
                var data = JsonConvert.DeserializeObject<JObject>(res);
                List<ErpAppUserResp> user_list = new List<ErpAppUserResp>();
                if (data != null && data["code"].ToString() == "200")
                {
                    user_list = JsonConvert.DeserializeObject<List<ErpAppUserResp>>(JsonConvert.SerializeObject(data["data"]));
                }
                var app_user_ids = user_list.Select(c => c.user_id).Distinct().ToList();
                var book_ids = _unitWork.Find<assets_book>(c => c.audit_status == 1 && c.status == 1
                    && ((c.use_type == 2 && c.start_time <= dt && c.over_time >= dt) || (c.use_type == 1 && c.has_returned == 0))
                    && app_user_ids.Contains(c.user_id))
                    .Select(c => new { c.assets_id, c.user_id, c.id }).GroupBy(c => new { c.user_id, c.assets_id }).Select(c => c.Max(d => d.id)).ToList();
                use_assets_ids = _unitWork.Find<assets_book>(c => book_ids.Contains(c.id)).Select(c => c.assets_id).ToList();
            }
            var assets_list = query.WhereIf(!string.IsNullOrWhiteSpace(key), c => c.name.Contains(key) || c.assets_no.Contains(key) || c.guid.Contains(key) || c.brand.Contains(key) || c.spec_no.Contains(key) || c.sn.Contains(key))
                .WhereIf(category_id > 0, c => category_ids.Contains(c.category_id))
                .WhereIf(purchase_order_no > 0, c => c.purchase_order_no == purchase_order_no)
                .WhereIf(room_id > 0, c => room_assets_ids.Contains(c.id))
                .WhereIf(guarantee_period_end != null, c => c.guarantee_period >= dt && c.guarantee_period <= guarantee_period_end)
                .WhereIf(status != -1 && status != 2, c => (c.status == status && c.use_type != 2) || (assets_ids.Contains(c.id) && c.use_type == 2))
                .WhereIf(status != -1 && status == 2, c => ((c.status == status && c.use_type != 2) || (assets_ids.Contains(c.id) && c.use_type == 2)) && c.use_type != 3)
                .WhereIf(!string.IsNullOrWhiteSpace(user_name), c => use_assets_ids.Contains(c.id))
                .Select(c => new
                {
                    c.assets_no,
                    c.brand,
                    c.category_id,
                    c.color,
                    c.cover_img,
                    c.created_on,
                    c.guarantee_period,
                    c.guid,
                    c.id,
                    c.is_bts,
                    c.name,
                    c.sn,
                    c.spec_no,
                    c.place,
                    c.purchase_date,
                    c.serial,
                    c.purchase_order_no,
                    c.use_type,
                    c.unit,
                    c.status,
                    c.item_code
                });
            serviceResult.Count = assets_list.Count();
            var assets = assets_list.OrderByDescending(c => c.id).Skip((PageIndex - 1) * PageCount).Take(PageCount).ToList();
            var assets_list_category_ids = assets.Select(c => c.category_id).Distinct().ToList();
            var assets_list_ids = assets.Select(c => c.id).ToList();
            var room_list = (from a in _unitWork.Find <room>(null)
                             join b in _unitWork.Find<assets_room_map>(null) on a.room_id equals b.room_id
                             where assets_list_ids.Contains(b.assets_id) && (a.customer_code == customer_code || a.user_id == -1) && a.status == 1 && a.create_source == 1
                             select new { a.room_id, a.name, b.assets_id }).ToList();
            var category_list = _unitWork.Find<assets_category>(c => assets_list_category_ids.Contains(c.id) && c.status == 1).Select(c => new { c.name, c.id }).ToList();
            var assets_list_user = (from a in _unitWork.Find<assets_book>(null)
                                    join b in _unitWork.Find<user>(null) on a.user_id equals b.user_id
                                    where assets_list_ids.Contains(a.assets_id) && a.audit_status == 1 && a.status == 1
                                     && ((a.use_type == 2 && a.start_time <= dt && a.over_time >= dt) || (a.use_type
                                     == 1 && a.has_returned == 0))
                                    select new { a.assets_id, a.user_id, b.real_name, b.department, b.nickname, book_id = a.id }).ToList();
            var user_ids = assets_list_user.Select(c => c.user_id).ToList();
           
            foreach (var c in assets)
            {
                string use_type_txt = string.Empty;
                string user = string.Empty;
                string status_txt = string.Empty;
                int user_id = 0;
                int book_id = 0;
                switch (c.use_type)
                {
                    case 1:
                        use_type_txt = "借用";
                        break;
                    case 2:
                        use_type_txt = "预约";
                        break;
                    case 3:
                        use_type_txt = "领用";
                        break;
                }
                var statusValue = c.status;
                switch (c.status)
                {
                    case 0:
                        status_txt = "禁用";
                        break;
                    case 1:
                    case 2:
                        var book_info = assets_list_user.FirstOrDefault(d => d.assets_id == c.id);
                        if (book_info != null)
                        {
                            //var erp_user = assets_user_list.Where(d => d.user_id == book_info.user_id).FirstOrDefault();
                            status_txt = "使用中";
                            //user = erp_user==null?(string.IsNullOrWhiteSpace(book_info.real_name)==true? book_info.real_name : book_info.real_name): erp_user.real_name;
                            var dep = string.IsNullOrWhiteSpace(book_info.department) == true ? "" : book_info.department + "-";
                            user = string.IsNullOrWhiteSpace(book_info.real_name) == true ? book_info.nickname : dep + book_info.real_name;
                            user_id = book_info.user_id;
                            book_id = book_info.book_id;
                        }
                        else
                        {
                            status_txt = "闲置";
                            statusValue = 1;
                        }
                        break;
                    case 3:
                        status_txt = "维修中";
                        break;
                    case 4:
                        status_txt = "报废";
                        break;
                    case 5:
                        status_txt = "已转储";
                        break;
                }
                var room_info = room_list.FirstOrDefault(d => d.assets_id == c.id);
                var category_info = category_list.FirstOrDefault(d => d.id == c.category_id);
                list.Add(new
                {
                    c.assets_no,
                    c.brand,
                    c.category_id,
                    c.color,
                    c.cover_img,
                    c.created_on,
                    c.guarantee_period,
                    c.guid,
                    c.id,
                    c.is_bts,
                    c.name,
                    c.sn,
                    c.spec_no,
                    c.place,
                    c.purchase_date,
                    c.serial,
                    c.purchase_order_no,
                    c.use_type,
                    c.unit,
                    category_name = category_info == null ? "" : category_info.name,
                    status_txt,
                    room_id = room_info == null ? 0 : room_info.room_id,
                    room = room_info == null ? "" : room_info.name,
                    use_type_txt,
                    user,
                    user_id,
                    status = statusValue,
                    book_id,
                    c.item_code

                });
            }
            serviceResult.Data = list;
            return serviceResult;
        }

        /// <summary>
        /// 根据category_id 得到所有子级category_id集合，包括自己
        /// </summary>
        /// <param name="customer_code">客户代码</param>
        /// <param name="category_id">类别id</param>
        /// <returns></returns>
        public List<int> GetAssetsCategoryIDLists(string customer_id, int category_id)
        {
            List<int> idLists = new List<int>();
            var assetsCategoryList = GetAllAssetsCategory(customer_id);
            var ParentList = assetsCategoryList.Where(c => c.id == category_id).FirstOrDefault();
            if (ParentList != null)
            {
                idLists.Add(category_id);
                GetChildrenAssetsCategoryIDLists(category_id, assetsCategoryList, ref idLists);
            }
            return idLists;
        }

        /// <summary>
        /// 获取分类列表
        /// </summary>
        /// <param name="customer_code"></param>
        /// <returns></returns>
        public List<assets_category> GetAllAssetsCategory(string customer_id)
        {
            return _unitWork.Find<assets_category>(c => c.customer_id == customer_id && c.status == 1).OrderBy(c => c.sort_idx).ToList();
        }
        /// <summary>
        /// 获取子集ID集合
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="allList"></param>
        /// <param name="idLists"></param>
        /// <returns></returns>
        public void GetChildrenAssetsCategoryIDLists(int Id, List<assets_category> allList, ref List<int> idLists)
        {
            var query = allList.Where(c => c.parent_id == Id).OrderBy(c => c.sort_idx).ToList();
            foreach (var item in query)
            {
                idLists.Add(item.id);
                GetChildrenAssetsCategoryIDLists(item.id, allList, ref idLists);
            }
        }
        
        public List<int> GetMaintainUserList(int Id)
        {
                var query = (from a in _unitWork.Find< assets_maintain_user >(null)
                             join b in _unitWork.Find<accounts>(null) on a.passport_id equals b.passport_id
                             where a.assets_id == Id && b.status == 1
                             select b.passport_id).ToList();
                return query;
        }

        /// <summary>
        /// 添加资产
        /// </summary>
        /// <param name="customer_code">添加人客户代码</param>
        /// <param name="user_Id">添加人用户Id</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertAssest(string customer_id, int passport_id, InsertAssetRequest model)
        {
            try
            {
                var sn = model.sn.Split(',');
                var room_info = _unitWork.Find<room>(c => c.room_id == model.roomId).FirstOrDefault();
                var assets_admin = _unitWork.Find<assets_admin_user>(c => c.passport_id == passport_id && c.customer_id == customer_id).FirstOrDefault();
                int counts = 0;
                if (model.use_type == 3)
                {
                    counts = 1;
                }
                else
                {
                    counts = Convert.ToInt32(model.number);
                }
                for (int i = 0; i < counts; i++)
                {
                    assets assetsInfo = new assets();
                    int assets_Id = 0;
                    assetsInfo.category_id = model.category_id;
                    assetsInfo.use_type = model.use_type;
                    assetsInfo.guid = "";
                    assetsInfo.name = model.name;
                    assetsInfo.assets_no = "";
                    assetsInfo.brand = !string.IsNullOrWhiteSpace(model.brand) ? model.brand : "";
                    assetsInfo.spec_no = model.spec_no;
                    assetsInfo.cover_img = string.IsNullOrWhiteSpace(model.cover_img) == true ? "" : "https://file.neware.work/" + model.cover_img;
                    assetsInfo.status = 1;
                    assetsInfo.place = model.place;
                    assetsInfo.is_sign = model.is_sign;
                    assetsInfo.is_audit = model.is_audit;
                    assetsInfo.created_on = DateTime.Now;
                    assetsInfo.created_by = passport_id;
                    assetsInfo.customer_id = customer_id;
                    assetsInfo.protocol_title = model.protocol_title == null ? "" : model.protocol_title;
                    assetsInfo.protocol_cont = model.protocol_cont == null ? "" : model.protocol_cont;
                    assetsInfo.is_open_maintain = model.is_open_maintain;
                    assetsInfo.data_add_source = model.data_add_source;
                    assetsInfo.instructions = string.IsNullOrWhiteSpace(model.instructions) == true ? "" : model.instructions;
                    assetsInfo.qr_code = string.IsNullOrWhiteSpace(model.qr_code) == true ? "" : model.qr_code;
                    assetsInfo.maintain_matter = model.maintain_matter;
                    assetsInfo.is_delete = false;
                    assetsInfo.is_bts = model.is_bts;
                    assetsInfo.is_book = true;
                    assetsInfo.price = model.price;
                    assetsInfo.purchase_date = model.purchase_date == null ? DateTime.Now : model.purchase_date;
                    assetsInfo.assets_source = model.assets_source;
                    assetsInfo.after_sale_contact = model.after_sale_contact;
                    assetsInfo.after_sale_tel = model.after_sale_tel;
                    assetsInfo.admin_passport_id = model.roomId == 0 ? 0 : model.admin_passport_id;
                    assetsInfo.unit = model.unit;
                    assetsInfo.color = model.color == null ? "" : model.color;
                    assetsInfo.serial = i + 1 + "/" + counts;
                    assetsInfo.purchase_order_no = model.purchase_order_no;
                    assetsInfo.is_open_inspect = model.is_open_inspect;
                    assetsInfo.is_show = assets_admin == null ? false : true;
                    assetsInfo.guarantee_period = model.guarantee_period;
                    assetsInfo.is_position = model.is_position;
                    assetsInfo.is_open_position = model.is_open_position;
                    assetsInfo.number = model.number;
                    if (i < sn.Length)
                    {
                        model.sn = sn[i];
                    }
                    if (room_info != null && room_info.create_source == 2)
                    {
                        assetsInfo.is_private = true;
                        assetsInfo.customer_id = "";
                    }
                    var info = _unitWork.Add<assets, int>(assetsInfo); ;
                    _unitWork.Save();
                    if (info != null)
                    {
                        assets_Id = info.id;
                        string str = "";
                        if (model.use_type == 1)
                        {
                            str = "JY_";
                        }
                        else if (model.use_type == 2)
                        {
                            str = "YY_";
                        }
                        else
                        {
                            str = "LY_";
                        }
                        info.assets_no = str + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + assets_Id.ToString();
                        info.guid = Md5_16ToUpper(assets_Id.ToString());
                        if (string.IsNullOrWhiteSpace(info.qr_code))
                        {
                            info.qr_code = info.id.ToString();
                        }
                        //绑定实验室
                        if (model.roomId != 0)
                        {
                            assets_room_map assetsRoomMap = new assets_room_map();
                            assetsRoomMap.assets_id = assets_Id;
                            assetsRoomMap.room_id = model.roomId;
                            assetsRoomMap.created_on = DateTime.Now;
                            assetsRoomMap.is_commonly_assets = 0;
                            assetsRoomMap.room2_id = 0;
                            assetsRoomMap.make_top_time = Convert.ToDateTime("1990-01-01 00:00:00");
                            _unitWork.Add<assets_room_map, int>(assetsRoomMap); ;
                            _unitWork.Save();
                        }
                        //保养信息
                        if (model.is_open_maintain == true)
                        {
                            foreach (var item in model.maintain_charge_user)
                            {
                                assets_maintain_user maintainInfo = new assets_maintain_user();
                                maintainInfo.assets_id = assets_Id;
                                maintainInfo.passport_id = item;
                                _unitWork.Add<assets_maintain_user, int>(maintainInfo); ;
                                _unitWork.Save();
                            }
                        }
                        //动态属性
                        if (model.assets_spec_list != null && model.assets_spec_list.Count > 0)
                        {
                            foreach (var item in model.assets_spec_list)
                            {
                                assets_spec_val assets_Spec_Val = new assets_spec_val();
                                assets_Spec_Val.assets_id = assets_Id;
                                assets_Spec_Val.spec_id = item.spec_id;
                                assets_Spec_Val.spec_val = item.spec_val;

                                _unitWork.Add<assets_spec_val, int>(assets_Spec_Val); ;
                                _unitWork.Save();
                            }
                        }
                        _unitWork.Save();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 编辑资产
        /// </summary>
        /// <param name="Id">资产Id</param>
        /// <param name="customer_code">客户代码</param>
        /// <param name="name">名称</param>
        /// <param name="guid">guid</param>
        /// <param name="category_id">资产类型</param>
        /// <param name="place">存放地点</param>
        /// <param name="roomId">实验室Id</param>
        /// <param name="use_type">使用类型</param>
        /// <param name="is_sign">是否签名</param>
        /// <param name="is_audit">是否审核</param>
        /// <param name="instructions">使用说明</param>
        /// <param name="protocol_title">协议标题</param>
        /// <param name="protocol_cont">协议内容</param>
        /// <param name="is_open_maintain">是否设置保养</param>
        /// <param name="maintain_matter">保养事项</param>
        /// <param name="maintain_charge_user">保养人</param>
        /// <param name="cover_img">资产图片</param>
        /// <param name="qr_code">二维码</param>
        /// <param name="spec_no">规格型号</param>
        /// <param name="price">价格</param>
        /// <param name="purchase_date">购买日期</param>
        /// <param name="assets_source">资产来源</param>
        /// <param name="after_sale_contact">售后负责人</param>
        /// <param name="after_sale_tel">售后电话</param>
        /// <param name="admin_user_id">管理员</param>
        /// <param name="unit">单位</param>
        /// <param name="color">颜色</param>
        /// <param name="assets_spec_list">动态属性</param>
        /// <param name="sn">sn码</param>
        /// <returns></returns>
        public bool EditAssets(string customer_id, int passport_id, InsertAssetRequest model)
        {

            try
            {
                assets assetsInfo = _unitWork.Find<assets>(c => c.id == model.Id).FirstOrDefault();
                var assets_admin = _unitWork.Find<assets_admin_user>(c => c.passport_id == passport_id && c.customer_id == customer_id).FirstOrDefault();
                if (assetsInfo == null)
                {
                    return false;
                }
                assetsInfo.category_id = model.category_id;
                assetsInfo.use_type = model.use_type;
                assetsInfo.name = model.name;
                assetsInfo.cover_img = string.IsNullOrWhiteSpace(model.cover_img) == true ? "" : "https://file.neware.work/" + model.cover_img;
                assetsInfo.spec_no = model.spec_no;
                assetsInfo.place = model.place;
                assetsInfo.is_sign = model.is_sign;
                assetsInfo.is_audit = model.is_audit;
                assetsInfo.protocol_title = model.protocol_title;
                assetsInfo.protocol_cont = model.protocol_cont;
                assetsInfo.is_open_maintain = model.is_open_maintain;
                assetsInfo.instructions = model.instructions;
                assetsInfo.maintain_matter = model.maintain_matter;
                assetsInfo.qr_code = model.qr_code;
                assetsInfo.assets_source = model.assets_source;
                assetsInfo.after_sale_contact = model.after_sale_contact;
                assetsInfo.after_sale_tel = model.after_sale_tel;
                assetsInfo.admin_passport_id = model.roomId == 0 ? 0 : model.admin_passport_id;
                assetsInfo.unit = model.unit;
                assetsInfo.color = model.color;
                assetsInfo.brand = model.brand;
                assetsInfo.number = model.number;
                if (assetsInfo.data_add_source != 3)
                {
                    assetsInfo.sn = string.IsNullOrWhiteSpace(model.sn) == true ? "" : model.sn;
                    assetsInfo.guarantee_period = model.guarantee_period;
                    assetsInfo.is_position = model.is_position;
                    assetsInfo.is_open_position = model.is_open_position;
                }
                assetsInfo.is_open_inspect = model.is_open_inspect;
                if (assets_admin != null)
                {
                    assetsInfo.is_show = model.is_show;
                }

                if (string.IsNullOrWhiteSpace(model.item_code))
                {
                    assetsInfo.purchase_order_no = model.purchase_order_no;

                    if (model.purchase_date > Convert.ToDateTime("1990-01-01 00:00:00"))
                    {
                        assetsInfo.purchase_date = model.purchase_date;
                    }
                    else
                    {
                        assetsInfo.purchase_date = null;
                    }
                    assetsInfo.price = model.price;
                }
                _unitWork.Save();
                //绑定实验室
                if (model.roomId != 0)
                {
                    var assetsRoomMap = _unitWork.Find<assets_room_map>(c => c.assets_id == model.Id).FirstOrDefault();
                    if (assetsRoomMap != null)
                    {
                        assetsRoomMap.room_id = model.roomId;
                        _unitWork.Save();
                    }
                    else
                    {
                        assets_room_map roomInfo = new assets_room_map();
                        roomInfo.room_id = model.roomId;
                        roomInfo.assets_id = model.Id;
                        roomInfo.created_on = DateTime.Now;
                        roomInfo.is_commonly_assets = 0;
                        roomInfo.make_top_time = Convert.ToDateTime("1990-01-01 00:00:00");

                        _unitWork.Add<assets_room_map, int>(roomInfo);
                        _unitWork.Save();
                    }
                }
                else
                {
                    var assetsRoomMap = _unitWork.Find<assets_room_map>(c => c.assets_id == model.Id).FirstOrDefault();
                    if (assetsRoomMap != null)
                    {
                        _unitWork.Delete<assets_room_map>(assetsRoomMap);
                        _unitWork.Save();
                    }
                }
                //保养人
                if (model.is_open_maintain == true)
                {
                    //删除原有保养人
                    var maintain_user = _unitWork.Find<assets_maintain_user>(c => c.assets_id == model.Id).ToList();
                    _unitWork.BatchDelete<assets_maintain_user>(maintain_user.ToArray());
                    _unitWork.Save();
                    foreach (var item in model.maintain_charge_user)
                    {
                        assets_maintain_user maintainInfo = new assets_maintain_user();
                        maintainInfo.assets_id = model.Id;
                        maintainInfo.passport_id = item;
                        _unitWork.Add<assets_maintain_user, int>(maintainInfo);
                    }
                    _unitWork.Save();
                }
                //动态属性
                if (model.assets_spec_list != null && model.assets_spec_list.Count > 0)
                {
                    var assets_spec_val = _unitWork.Find<assets_spec_val>(c => c.assets_id == model.Id).ToList();
                    _unitWork.BatchDelete<assets_spec_val>(assets_spec_val.ToArray());
                    _unitWork.Save();
                    foreach (var item in model.assets_spec_list)
                    {
                        assets_spec_val assets_Spec_Val = new assets_spec_val();
                        assets_Spec_Val.assets_id = model.Id;
                        assets_Spec_Val.spec_id = item.spec_id;
                        assets_Spec_Val.spec_val = item.spec_val;

                        _unitWork.Add<assets_spec_val, int>(assets_Spec_Val);
                    _unitWork.Save();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                //LoggerHelper.Error("EditAssets", ex);
                return false;
            }
        }

        /// <summary>
        /// 单个删除资产
        /// </summary>
        public bool DeleteAssetsById(int passport_id, int assets_id, out string error_message)
        {

            try
            {
                // 资产不可删除判断 1.非闲置资产，2 处于预约的申请单，通过+待审核 
                var assets_info = _unitWork.Find<assets>(r => r.id == assets_id).FirstOrDefault();
                if (assets_info == null)
                {
                    error_message = "找不到该资产！";
                    return false;
                }
                if (assets_info.use_type != 2)
                {
                    if (assets_info.status != 1)
                    {
                        error_message = "非闲置资产不可删除！";
                        return false;
                    }
                }
                else
                {
                    DateTime dt = DateTime.Now;

                    if (assets_info.status != 1 && assets_info.status != 2)
                    {
                        error_message = "非闲置资产不可删除！";
                        return false;
                    }

                    // 使用中
                    var current_book = _unitWork.Find<assets_book>(c => c.assets_id == assets_id && c.status == 1 && c.audit_status == 1 && c.start_time < dt && c.over_time > dt).FirstOrDefault();
                    if (current_book != null)
                    {
                        error_message = "非闲置资产不可删除！";
                        return false;
                    }

                    var assets_book_list = _unitWork.Find<assets_book>(c => c.assets_id == assets_id && c.status == 1 && c.audit_status != 2 && c.over_time >= dt && c.use_type == 2).Select(c => c.assets_id).Distinct().ToList();
                    if (current_book != null)
                    {
                        error_message = "预约类型资产存在预约，不可删除！";
                        return false;
                    }
                }

                var is_bind = _unitWork.Find<assets_positioner_bind>(c => c.positioner_assets_id == assets_id || c.assets_id == assets_id).Any();
                if (is_bind)
                {
                    error_message = "该资产关联其他资产或定位器，请先解除绑定关系！";
                    return false;
                }
                if (assets_info.is_bts == true && assets_info.bts_type == 2)
                {
                    // 删除温箱的映射关系
                    var incubator_map_list = _unitWork.Find<assets_incubator_map>(c => c.assets_id == assets_id).ToList();
                    _unitWork.BatchDelete<assets_incubator_map>(incubator_map_list.ToArray());

                }

                var room_map = _unitWork.Find<assets_room_map>(c => c.assets_id == assets_id).ToList();
                var maintain_users = _unitWork.Find<assets_maintain_user>(c => c.assets_id == assets_id).ToList();

                _unitWork.BatchDelete<assets_room_map>(room_map.ToArray());
                _unitWork.BatchDelete<assets_maintain_user>(maintain_users.ToArray());
                _unitWork.Delete<assets>(assets_info);
                var privateFlag = assets_info.is_private == false ? "" : "私有";
                // 写入sys_log
                var str_content = "资产删除：" + assets_info.name + "(assets_id:" + assets_info.id + "), guid：" + assets_info.guid + "，" + privateFlag + "的资产已被删除";
                sys_log log = new sys_log();
                log.type = 2;
                log.passport_id = passport_id;
                log.content = str_content;
                _unitWork.Add<sys_log,int>(log);

                _unitWork.Save();
                error_message = "";
                return true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// 将要发送的消息信息写入数据库
        /// </summary>
        /// <param name="msgTitle">消息标题</param>
        /// <param name="msgContent">消息体</param>
        /// <param name="contentId">内容id</param>
        /// <param name="contentType">内容类型，1：文章，2：动态 3</param>
        /// <param name="payload">payload信息</param>
        /// <param name="reciveUserIds">推送对象id</param>
        /// <param name="msgType">消息类型 1-系统通知 2-赞和收藏 3-关注 4-评论 5-设备相关 6-实验室相关 7-资产定位消息预警</param>
        /// <param name="fromUserId">消息来源userid</param>
        /// <param name="msg_operation_type">消息操作类型（0-无需操作，1-点击操作）</param>
        /// <param name="writeMessage">是否写入消息中心 true/false </param>
        /// <param name="writePush">是否写入App推送 true/false</param>
        /// <returns></returns>
        public bool MsgWriteInTable(string msgTitle, string msgContent, int contentId, sbyte contentType, string payload, List<int> reciveUserIds, sbyte msgType, int fromUserId, int msg_operation_type = 0, string operation_url = "")
        {

            var fromUser = _unitWork.Find<user>(u => u.user_id == fromUserId).FirstOrDefault();
            var all_user = _unitWork.Find<user>(u => reciveUserIds.Contains(u.user_id)).ToList();
            foreach (var userId in reciveUserIds)
            {
                var reciveUser = all_user.Where(u => u.user_id == userId).FirstOrDefault();
                if (reciveUser == null || string.IsNullOrWhiteSpace(reciveUser.push_cid))
                {
                    continue;
                }
                sys_app_push msg = new sys_app_push
                {
                    push_cid = reciveUser.push_cid,
                    title = msgTitle,
                    content = fromUser == null ? msgContent : fromUser.nickname + "  " + msgContent,
                    content_id = contentId,
                    content_type = contentType,
                    payload = payload,
                    has_push = false,
                };
                _unitWork.Add<sys_app_push, int>(msg);
                if (msgType != 0)//有的消息无需展示的消息中心
                {
                    app_notice notice = new app_notice
                    {
                        type = msgType,
                        user_id = reciveUser.user_id,
                        rel_id = contentId,
                        rel_type = contentType,
                        from_user_id = fromUserId,
                        title = msgTitle,
                        content = msgContent,
                        has_read = false,
                        msg_operation_type = msg_operation_type,
                        url = operation_url
                    };
                    _unitWork.Add<app_notice, int>(notice);
                }
            }
            _unitWork.Save();
            return true;
        }
        /// <summary>
        /// MD5 16位加密 加密后密码为大写
        /// </summary>
        /// <param name="ConvertString"></param>
        /// <returns></returns>
        public static string Md5_16ToUpper(string s, Encoding encoding = null)
        {
            if (s == null || s.Length == 0)
                return string.Empty;
            if (encoding == null)
                encoding = Encoding.UTF8;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                string result = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(s)), 4, 8);
                result = result.Replace("-", "");
                return result;
            }
        }

        /// <summary>
        /// 根据二维码获取资产信息
        /// </summary>
        /// <param name="qr_code"></param>
        /// <param name="customer_code"></param>
        /// <returns></returns>
        public assets GetAssetsInfoByCode(string qr_code, string customer_id)
        {
            return _unitWork.Find<assets>(c => c.qr_code == qr_code && c.customer_id == customer_id).FirstOrDefault();
        }

        #endregion


        #region 批量处理

        /// <summary>
        /// 资产批量编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TableData AssetsBatchEdit(AssetsBatchEditReq model)
        {
            //ServiceResult serviceResult = new ServiceResult();
            TableData serviceResult = new TableData();
            try
            {
                DateTime dt = DateTime.Now;
                List<int> ids = model.select_list.Select(c => c.Id).ToList();
                List<int> ids_book = model.select_list.Where(c => c.use_type == 2).Select(c => c.Id).ToList();
                var assets_book_list = _unitWork.Find<assets_book>(c => ids_book.Contains(c.assets_id) && c.status == 1 && c.audit_status != 2 && c.over_time >= dt && c.use_type == 2).Select(c => c.assets_id).Distinct().ToList();
                var uedit_assets_list = _unitWork.Find<assets>(c => assets_book_list.Contains(c.id)).Select(c => new { name = c.name + "(" + c.guid + ")" }).ToList();
                List<int> edit_ids = ids.Except(assets_book_list).ToList();
                var assets_list = _unitWork.Find<assets>(c => edit_ids.Contains(c.id) && c.is_delete == false).ToList();
                var assets_room_list = _unitWork.Find<assets_room_map>(c => edit_ids.Contains(c.assets_id)).ToList();
                List<assets_room_map> assets_room_maps_remove = new List<assets_room_map>();
                List<assets_room_map> assets_room_maps_add = new List<assets_room_map>();
                List<assets_maintain_user> maintain_users = new List<assets_maintain_user>();
                List<assets_incubator_map> assets_incubator_map = new List<assets_incubator_map>();
                foreach (var item in assets_list)
                {
                    item.category_id = model.category_id != 0 == true ? model.category_id : item.category_id;
                    item.place = !string.IsNullOrWhiteSpace(model.place) ? model.place : item.place;
                    item.use_type = model.use_type != 0 == true ? model.use_type : item.use_type;
                    item.assets_source = model.assets_source != 0 == true ? model.assets_source : item.assets_source;
                    item.price = model.price != -1 == true ? model.price : item.price;
                    var assets_room = assets_room_list.Where(c => c.assets_id == item.id).FirstOrDefault();
                    if (assets_room != null)
                    {
                        if (assets_room.room_id != model.room_id)
                        {
                            if (model.room_id != 0)
                            {
                                assets_room.room_id = model.room_id;
                                assets_room.room2_id = 0;
                                if (item.is_bts == true && item.bts_type == 2)
                                {
                                    var assets_Incubator_Maps_List = _unitWork.Find<assets_incubator_map>(c => c.assets_id == item.id && c.room_id == model.room_id).ToList();
                                    assets_incubator_map.AddRange(assets_Incubator_Maps_List);
                                }
                            }
                        }
                    }
                    else
                    {
                        assets_room_map assets_Room_Map = new assets_room_map();
                        assets_Room_Map.assets_id = item.id;
                        assets_Room_Map.room_id = model.room_id;
                        assets_Room_Map.created_on = DateTime.Now;
                        assets_Room_Map.is_commonly_assets = 1;
                        assets_room_maps_add.Add(assets_Room_Map);
                    }
                    item.admin_user_id = model.admin_user_id != 0 == true ? model.admin_user_id : item.admin_user_id;
                    item.is_sign = model.is_sign == -1 ? item.is_sign : (model.is_sign == 0 ? false : true);
                    item.is_audit = model.is_audit == -1 ? item.is_audit : (model.is_audit == 0 ? false : true);
                    item.instructions = string.IsNullOrWhiteSpace(model.instructions) == true ? item.instructions : model.instructions;
                    item.after_sale_contact = string.IsNullOrWhiteSpace(model.after_sale_contact) == true ? item.after_sale_contact : model.after_sale_contact;
                    item.after_sale_tel = string.IsNullOrWhiteSpace(model.after_sale_tel) == true ? item.after_sale_tel : model.after_sale_tel;
                    item.is_open_maintain = model.is_open_maintain == -1 ? item.is_open_maintain : (model.is_open_maintain == 0 ? false : true);
                    item.maintain_matter = string.IsNullOrWhiteSpace(model.maintain_matter) == true ? item.maintain_matter : model.maintain_matter;
                    if (model.guarantee_period > DateTime.Parse("1990-01-01"))
                    {
                        item.guarantee_period = model.guarantee_period;
                    }
                    if (model.is_open_maintain == 1)
                    {
                        //删除原有保养人
                        var maintain_user = _unitWork.Find<assets_maintain_user>(c => c.assets_id == item.id).ToList();
                        _unitWork.BatchDelete<assets_maintain_user>(maintain_user.ToArray());
                        //entity.assets_maintain_user.RemoveRange(maintain_user);
                        _unitWork.Save();
                        foreach (var row in model.assets_maintain_user)
                        {
                            assets_maintain_user maintainInfo = new assets_maintain_user();
                            maintainInfo.assets_id = item.id;
                            maintainInfo.user_id = row;
                            maintain_users.Add(maintainInfo);
                        }
                    }
                }
                _unitWork.BatchAdd<assets_maintain_user, int>(maintain_users.ToArray());
                _unitWork.BatchDelete<assets_room_map>(assets_room_maps_remove.ToArray());
                _unitWork.BatchAdd<assets_room_map, int>(assets_room_maps_add.ToArray());
                _unitWork.BatchAdd<assets_incubator_map, int>(assets_incubator_map.ToArray());
                _unitWork.Save();
                serviceResult.Data = uedit_assets_list;
                return serviceResult;
            }
            catch (Exception ex)
            {
                serviceResult.Message = ex.Message;
                serviceResult.Code = 500;
                return serviceResult;
            }
        }



        /// <summary>
        /// 资产批量删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public TableData AssetsBatchDelete(List<AssetsBatchSelect> list, int user_id)
        {
            TableData serviceResult = new TableData();
            try
            {
                DateTime dt = DateTime.Now;
                List<int> ids = list.Select(c => c.Id).ToList();
                List<int> ids_book = list.Where(c => c.use_type == 2).Select(c => c.Id).ToList();
                List<int> udelete_assets_ids = new List<int>();

                var assets_book_ids = _unitWork.Find<assets_book>(c => ids_book.Contains(c.assets_id) && c.status == 1 && c.audit_status != 2 && c.over_time >= dt && c.use_type == 2).Select(c => c.assets_id).Distinct().ToList();
                udelete_assets_ids.AddRange(assets_book_ids);
                var assets_positioner_bind = _unitWork.Find<assets_positioner_bind>(null).ToList();
                var positioner_bind_assets_ids = assets_positioner_bind.Select(c => c.assets_id).ToList();
                udelete_assets_ids.AddRange(positioner_bind_assets_ids);
                var positioner_assets_ids = assets_positioner_bind.Select(c => c.positioner_assets_id).ToList();
                udelete_assets_ids.AddRange(positioner_assets_ids);

                var udelete_assets_list = _unitWork.Find<assets>(c => udelete_assets_ids.Contains(c.id)).Select(c => new { name = c.name + "(" + c.guid + ")" }).ToList();
                List<int> delete_ids = ids.Except(udelete_assets_ids).ToList();
                var assets_list = _unitWork.Find<assets>(c => delete_ids.Contains(c.id) && c.is_delete == false).ToList();
                var assets_room_list = _unitWork.Find<assets_room_map>(c => delete_ids.Contains(c.assets_id)).ToList();
                List<assets_incubator_map> assets_incubator_map_list = new List<assets_incubator_map>();
                List<assets_room_map> assets_room_maps_remove = new List<assets_room_map>();
                List<assets_maintain_user> maintain_users = new List<assets_maintain_user>();
                foreach (var item in assets_list)
                {
                    var assets_room = assets_room_list.Where(c => c.assets_id == item.id).FirstOrDefault();
                    if (assets_room != null)
                    {
                        assets_room_maps_remove.Add(assets_room);
                    }
                }
                assets_incubator_map_list = _unitWork.Find<assets_incubator_map>(c => delete_ids.Contains(c.assets_id)).ToList();
                maintain_users = _unitWork.Find<assets_maintain_user>(c => delete_ids.Contains(c.assets_id)).ToList();

                _unitWork.BatchDelete<assets_incubator_map>(assets_incubator_map_list.ToArray());
                _unitWork.BatchDelete<assets>(assets_list.ToArray());
                _unitWork.BatchDelete<assets_room_map>(assets_room_maps_remove.ToArray());
                _unitWork.BatchDelete<assets_maintain_user>(maintain_users.ToArray());

                _unitWork.Save();

                // 写入sys_log
                foreach (var item in assets_list)
                {
                    var privateFlag = item.is_private == false ? "" : "私有";
                    var str_content = "资产删除：" + item.name + "(assets_id:" + item.id + "), guid：" + item.guid + "，" + privateFlag + "的资产已被删除";
                    sys_log log = new sys_log();
                    log.type = 2;
                    log.user_id = user_id;
                    log.content = str_content;
                    _unitWork.Add<sys_log, int>(log);
                    _unitWork.Save();
                }

                serviceResult.Data = udelete_assets_list;
                return serviceResult;
            }
            catch (Exception ex)
            {
                serviceResult.Message = ex.Message;
                serviceResult.Code = 500;
                return serviceResult;
            }

        }



        #endregion

        /// <summary>
        /// 根据名称获取分类名称
        /// </summary>
        /// <param name="parent_id"></param>
        /// <param name="name"></param>
        /// <param name="customer_code"></param>
        /// <returns></returns>
        public assets_category GetAssetsCategoryByName(int parent_id, string name, string customer_id)
        {
            return _unitWork.Find<assets_category>(c => c.parent_id == parent_id && c.customer_id == customer_id && c.name == name && c.status == 1).FirstOrDefault();
        }

        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="parent_id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="customer_code"></param>
        /// <returns></returns>
        public bool AddAssetsCategory(int parent_id, string name, string customer_id)
        {
            assets_category model = new assets_category();
            model.name = name;
            model.parent_id = parent_id;
            model.sort_idx = 200;
            model.customer_id = customer_id;
            // 允许删除
            model.data_source = 1;
            model.status = 1;
            model.remark = "";
            var sysconfig = _unitWork.Find<sys_config>(c => c.key == "assetsTypeImage").FirstOrDefault();
            model.type_url = sysconfig == null ? "" : sysconfig.val;
            _unitWork.Add<assets_category, int>(model);
            _unitWork.Save();
            return true;
        }
        /// <summary>
        /// 获取子集
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="allList"></param>
        /// <returns></returns>
        public List<ChildrenCategoryInfo> GetChildrenAssetsCategory(int Id, List<assets_category> allList)
        {
            var query = allList.Where(c => c.parent_id == Id).OrderBy(c => c.sort_idx).ToList();
            List<ChildrenCategoryInfo> childrenList = new List<ChildrenCategoryInfo>();
            foreach (var item in query)
            {
                ChildrenCategoryInfo model = new ChildrenCategoryInfo();
                model.id = item.id;
                model.name = item.name;
                model.parent_id = item.parent_id;
                model.type_url = item.type_url;
                model.childrebList = GetChildrenAssetsCategory(item.id, allList);
                if (model.childrebList.Count() == 0)
                {
                    model.childrebList = null;
                }
                childrenList.Add(model);
            }
            return childrenList;
        }
        /// <summary>
        /// 更新资产类别关联的属性
        /// </summary>
        /// <returns></returns>
        /// <param name="category_id">资产类型ID</param>
        /// <param name="specIds">属性id list</param>
        public TableData UpdateCategorySpecs(int category_id, List<int> specIds)
        {
            TableData serviceResult = new TableData();
            try
            {
                var category = _unitWork.Find<assets_category>(m => m.id == category_id).FirstOrDefault();
                if (category == null)
                {
                    serviceResult.Message = "找不到该资产类型!";
                    serviceResult.Code = 500;
                    return serviceResult;
                }
                var categorySpecIds = _unitWork.Find<assets_cate_spec_map>(m => m.category_id == category_id).Select(m => m.spec_id).ToList();
                foreach (var sid in specIds)
                {
                    if (categorySpecIds.Contains(sid))
                        continue;
                    assets_cate_spec_map map = new assets_cate_spec_map
                    {
                        category_id = category_id,
                        spec_id = sid
                    };
                    _unitWork.Add<assets_cate_spec_map, int>(map);
                }
                foreach (var sid in categorySpecIds)
                {
                    if (specIds.Contains(sid))
                        continue;
                    var map = _unitWork.Find<assets_cate_spec_map>(m => m.category_id == category_id && m.spec_id == sid).FirstOrDefault();
                    if (map == null)
                        continue;
                    _unitWork.Delete(map);
                }
                _unitWork.Save();
            }
            catch (Exception ex)
            {
                serviceResult.Message = "更新资产类别关联属性失败!";
                serviceResult.Code = 500;
                return serviceResult;
            }
            return serviceResult;
        }

        /// <summary>
        /// 删除规格属性
        /// </summary>
        /// <param name="category_id">资产类型ID</param>
        /// <param name="specIds">属性id list</param>
        /// <returns></returns>
        public TableData DeleteSpecs(string customer_id, List<int> specIds)
        {
            TableData serviceResult = new TableData();

            try
            {
                var map_spec_ids = (from a in _unitWork.Find<assets_spec>(null)
                                    join b in _unitWork.Find<assets_cate_spec_map>(null) on a.id equals b.spec_id
                                    join c in _unitWork.Find<assets_category>(null) on b.category_id equals c.id
                                    where a.customer_id == customer_id
                                    && c.customer_id == customer_id
                                    && c.status == 1
                                    select a.id).Distinct().ToList();

                foreach (var spec_id in specIds)
                {
                    var spec_Info = _unitWork.Find<assets_spec>(c => c.id == spec_id && c.customer_id == customer_id).FirstOrDefault();
                    if (spec_Info == null)
                        continue;
                    if (map_spec_ids.Contains(spec_id))
                    {
                        serviceResult.Message = "【" + spec_Info.spec_name + "】关联着资产类型！";
                        serviceResult.Code = 500;
                        return serviceResult;
                    }
                    var categoryMaps = _unitWork.Find<assets_cate_spec_map>(m => m.spec_id == spec_id).ToList();
                    var specVals = _unitWork.Find<assets_spec_val>(v => v.spec_id == spec_id).ToList();
                    _unitWork.BatchDelete<assets_cate_spec_map>(categoryMaps.ToArray());
                    _unitWork.BatchDelete<assets_spec_val>(specVals.ToArray());
                    _unitWork.Delete<assets_spec>(spec_Info);
                    _unitWork.Save();
                }
            }
            catch (Exception ex)
            {
                serviceResult.Code = 500;
                serviceResult.Message = "删除属性失败!";
                return serviceResult;
            }
            return serviceResult;
        }
        /// <summary>
        /// 新增属性规格
        /// </summary>
        /// <returns></returns>
        /// <param name="spec_name">属性名称</param>
        /// <param name="msg">返回信息</param>
        public bool AddSpec(string spec_name, string customer_id, out string msg)
        {
            try
            {
                if (string.IsNullOrEmpty(spec_name))
                {
                    msg = "属性名称不能为空！";
                    return false;
                }
                var data = _unitWork.Find<assets_spec>(c => c.customer_id == customer_id).ToList();
                var query = data.Where(c => c.spec_name == spec_name);

                if (query.Count() > 0)
                {
                    msg = "已有相同名称属性，请重新命名!";
                    return false;
                }
                if (data.Count >= 30)
                {
                    msg = "属性规格数量已大于30个，无法继续添加!";
                    return false;
                }
                assets_spec spec = new assets_spec
                {
                    spec_name = spec_name,
                    parent_id = 0,
                    can_null = false,
                    input_type = 1,
                    customer_id = customer_id
                };
                _unitWork.Add<assets_spec, int>(spec);
                _unitWork.Save();
                msg = "新增成功！";
                return true;
            }
            catch (Exception ex)
            {
                msg = "新增失败" + ex.Message + "!";
                return false;
            }
        }

        /// <summary>
        /// 校验是否为管理员
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool CheckManager(int passport_id, string customer_id)
        {
            var user = _unitWork.Find<assets_admin_user>(u => u.passport_id == passport_id && u.customer_id == customer_id).FirstOrDefault();
            if (user == null)
                return false;
            else
                return true;
        }
        /// <summary>
        /// 获取售后Xtoken
        /// </summary>
        /// <returns></returns>
        public TableData GetXToken()
        {

            TableData serviceResult = new TableData();
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string url = Configuration.GetSection("ERP4Url").Value  + "/api/Check/Login";
                    dynamic obj = new { account = "App", password = "newareapp", appKey = "newareapp" };
                    string param = JsonConvert.SerializeObject(obj);
                    HttpContent content = new StringContent(param);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    Task<HttpResponseMessage> responseMessage = httpClient.PostAsync(url, content);
                    responseMessage.Wait();
                    Task<string> reString = responseMessage.Result.Content.ReadAsStringAsync();
                    reString.Wait();
                    var result = JsonConvert.DeserializeObject<JObject>(reString.Result);
                    if (result["code"] == null || result["code"].ToString() != "200")
                    {
                        serviceResult.Code = 500;
                        serviceResult.Message = result["message"].ToString();
                    }
                    serviceResult.Data = result["token"].ToString();
                }
            }
            catch (Exception ex)
            {
                serviceResult.Code = 500;
                serviceResult.Message = ex.Message.ToString();
            }
            return serviceResult;
        }
        public static string HttpsPost(string posturl, string postData, string token = "")
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            byte[] data = Encoding.UTF8.GetBytes(postData);
            try
            {
                if (posturl.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(CheckValidationResult);
                    request = WebRequest.Create(posturl) as HttpWebRequest;
                    request.ProtocolVersion = HttpVersion.Version10;
                }
                else
                {
                    request = WebRequest.Create(posturl) as HttpWebRequest;
                }
                if (!string.IsNullOrWhiteSpace(token))
                {
                    request.Headers["X-Token"] = token;
                }
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.Timeout = 60000;
                request.Headers["Accept-Encoding"] = "gzip,deflate,br";
                request.ContentType = "application/json";
                request.Accept = "*/*";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                response = request.GetResponse() as HttpWebResponse;
                if ("gzip".Equals(response.ContentEncoding))
                {
                    instream = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                }
                else if ("deflate".Equals(response.ContentEncoding))
                {
                    instream = new System.IO.Compression.DeflateStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                }
                else
                {
                    instream = response.GetResponseStream();
                }
                sr = new StreamReader(instream, Encoding.UTF8);
                string content = sr.ReadToEnd();
                return content;
            }
            catch (Exception ex)
            {
                var obj = new { status = 500, message = ex.Message, data = new object() };
                return JsonConvert.SerializeObject(obj);
            }
        }
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        public class ErpAppUserResp
        {
            public int user_id { get; set; }
            public string real_name { get; set; }
            public string entry_time { get; set; }
        }
    }

}
