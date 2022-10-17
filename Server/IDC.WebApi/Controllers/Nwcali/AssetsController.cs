using IDC.Application.Common;
using IDC.Application.Nwcali;
using IDC.Application.Nwcali.Request;
using IDC.Application.Nwcali.Response;
using IDC.Infrastructure.Redis;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Nwcali
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Nwcali")]

    public class AssetsController : ControllerBase
    {
        private readonly AssetsApp _app;
        private readonly FileApp _fileApp;
        public IConfiguration Configuration { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public AssetsController(AssetsApp app, FileApp fileApp, IConfiguration configuration)
        {
            _app = app;
            _fileApp = fileApp;
            Configuration = configuration;
        }

        #region App
        /// <summary>
        /// 普通资产列表(web)
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
        /// <param name="isMap">是否需要排除组合资产</param>
        /// <param name="customer_code">用户编码</param>
        [HttpGet]
        public async Task<TableData> AssetsList(string key = "", int purchase_order_no = 0, int category_id = 0, int room_id = 0, int status = -1,
       string guarantee_period_end = "", int PageCount = 20, int PageIndex = 1, int is_show = 1, bool isMap = false, string customer_code = "")
        {
            var result = new TableData();
            try
            {
                return await _app.AssetsList(key, purchase_order_no, category_id, room_id, status, guarantee_period_end, PageCount, PageIndex, is_show, isMap, customer_code);

            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 新增资产
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AddAssets(InsertAssetRequest model)
        {
            TableData apiResult = new TableData();
            if (string.IsNullOrWhiteSpace(model.name))
            {
                apiResult.Code = 500;
                apiResult.Message = "资产名称不能为空!";
                return apiResult;
            }
            if (model.category_id <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "资产未选择类型!";
                return apiResult;
            }
            if (string.IsNullOrWhiteSpace(model.place))
            {
                apiResult.Code = 500;
                apiResult.Message = "资产存放地址不能为空!";
                return apiResult;
            }
            if (model.purchase_date == null)
            {
                apiResult.Code = 500;
                apiResult.Message = "购入日期不能为空!";
                return apiResult;
            }
            if (model.assets_source <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择资产来源!";
                return apiResult;
            }
            if (model.admin_user_id <= 0 && model.roomId != 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择对应的管理员!";
                return apiResult;
            }
            if (model.use_type <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择使用方式!";
                return apiResult;
            }
            if (!string.IsNullOrWhiteSpace(model.qr_code))
            {
                //校验二维码
                var assets_info = _app.GetAssetsInfoByCode(model.qr_code, model.customer_code);
                if (assets_info != null)
                {
                    apiResult.Code = 500;
                    apiResult.Message = "二维码已存在,请重新输入!";
                    return apiResult;
                }
            }
            if (model.is_open_maintain == true)
            {
                if (string.IsNullOrWhiteSpace(model.maintain_matter))
                {
                    apiResult.Code = 500;
                    apiResult.Message = "参数错误,资产保养事项不能为空!";
                    return apiResult;
                }
                if (model.maintain_charge_user.Count <= 0)
                {
                    apiResult.Code = 500;
                    apiResult.Message = "参数错误,资产保养负责人不能为空!";
                    return apiResult;
                }
            }
            if (string.IsNullOrWhiteSpace(model.cover_img))
            {
                apiResult.Code = 500;
                apiResult.Message = "必须上传资产图片!";
                return apiResult;
            }
            if (model.use_type == 3 && model.number <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请输入资产数量!";
                return apiResult;
            }
            if (string.IsNullOrWhiteSpace(model.unit) && model.use_type == 3)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择单位!";
                return apiResult;
            }
            if (model.is_position && string.IsNullOrWhiteSpace(model.sn))
            {
                apiResult.Code = 500;
                apiResult.Message = "请填写定位器的sn码!";
                return apiResult;
            }
            model.number = model.number < 1 ? 1 : model.number;
            bool InsertSuccess = _app.InsertAssest(model.customer_code, model.user_id, model);
            if (!InsertSuccess)
            {
                apiResult.Code = 500;
                return apiResult;
            }//////  

            //推送
            if (model.is_open_maintain == true && model.maintain_charge_user.Count > 0)
            {
                var msgSuccess = _app.MsgWriteInTable("资产日常保养通知", "您已被设为" + model.name + "资产保养负责人。", 0, 0, "", model.maintain_charge_user, 5, 0, 0);
                if (!msgSuccess)
                {
                    //LoggerHelper.Error("" + model.name + "资产日常保养通知异常!", "Assets/AddAssets", string.Empty);
                }
            }
            if (model.roomId != 0)
            {
                bool isTest = System.Convert.ToBoolean(Configuration.GetSection("IsTestEnvironment").Value);
                string api_version = Configuration.GetSection("api_version").Value;

                string redisKey = isTest ? "test_room" + model.roomId + "_alldevs" : "room" + model.roomId + "_alldevs";
                string redisKey2 = isTest ? "test_room" + model.roomId + "_chooselabel" : "room" + model.roomId + "_chooselabel";
                string redisCommonlyDevKey = isTest ? "test_room" + model.roomId + "_CommonlyDev_" + api_version : "room" + model.roomId + "_CommonlyDev_" + api_version;
                AppRedis.Del(redisKey);
                AppRedis.Del(redisKey2);
                AppRedis.Del(redisCommonlyDevKey);

            }
            return apiResult;
        }

        /// <summary>
        /// 编辑资产（单个编辑）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> EditAssets(InsertAssetRequest model)
        {
            TableData apiResult = new TableData();
            bool isTest = System.Convert.ToBoolean(Configuration.GetSection("IsTestEnvironment").Value);

            //var flag = Business.AssetsApp.Instance.AssetsIsIdle(model.Id);
            //if (!flag)
            //{
            //    apiResult.Error(ErrorCode.Error_Message_Code);
            //    apiResult.ErrorMessage = "非闲置资产不可编辑!";
            //    return Json(apiResult);
            //}
            if (string.IsNullOrWhiteSpace(model.name))
            {
                apiResult.Code = 500;
                apiResult.Message = "参数错误,资产名称不能为空!";
                return apiResult;
            }
            if (model.category_id <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "资产未选择类型!";
                return apiResult;
            }
            if (model.purchase_date == null)
            {
                apiResult.Code = 500;
                apiResult.Message = "购入日期不能为空!";
                return apiResult;
            }
            if (model.assets_source <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择资产来源!";
                return apiResult;
            }
            if (model.admin_user_id <= 0 && model.roomId != 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择对应的管理员!";
                return apiResult;
            }
            if (string.IsNullOrWhiteSpace(model.place))
            {
                apiResult.Code = 500;
                apiResult.Message = "参数错误,资产存放地址不能为空!!";
                return apiResult;
            }
            if (string.IsNullOrWhiteSpace(model.cover_img))
            {
                apiResult.Code = 500;
                apiResult.Message = "必须上传资产图片!";
                return apiResult;
            }
            if (model.is_open_maintain == true)
            {
                if (string.IsNullOrWhiteSpace(model.maintain_matter))
                {
                    apiResult.Code = 500;
                    apiResult.Message = "参数错误,资产保养事项不能为空!!";
                    return apiResult;
                }
                if (model.maintain_charge_user.Count <= 0)
                {
                    apiResult.Code = 500;
                    apiResult.Message = "参数错误,资产保养负责人不能为空!!";
                    return apiResult;
                }
            }
            if (string.IsNullOrWhiteSpace(model.unit) && model.use_type == 3)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择单位!";
                return apiResult;
            }
            if (model.is_position && string.IsNullOrWhiteSpace(model.sn))
            {
                apiResult.Code = 500;
                apiResult.Message = "请填写定位器的sn码!";
                return apiResult;
            }
            //保养人变化部分
            var maintain_userList =_app.GetMaintainUserList(model.Id);//原有保养人
            List<int> newAddUser = new List<int>();
            if (model.maintain_charge_user.Count > 0)
            {
                newAddUser = model.maintain_charge_user.Except(maintain_userList).ToList();
            }
            //更新
            var result = _app.EditAssets(model.customer_code, model.user_id, model);
            if (!result)
            {
                apiResult.Code = 500;
                apiResult.Message = "编辑失败!";
                return apiResult;
            }
            //推送
            if (model.is_open_maintain == true && newAddUser.Count > 0)
            {
                var msgSuccess = _app.MsgWriteInTable("资产日常保养通知", "您已被设为" + model.name + "资产保养负责人。", 0, 0, "", newAddUser, 5, 0, 0);
                if (!msgSuccess)
                {
                    //LoggerHelper.Error("" + model.name + "资产日常保养通知异常!", "Assets/EditAssets", string.Empty);
                }
            }
            if (model.roomId != 0)
            {
                string redisKey = isTest ? "test_room" + model.roomId + "_alldevs" : "room" + model.roomId + "_alldevs";
                string redisKey2 = isTest ? "test_room" + model.roomId + "_chooselabel" : "room" + model.roomId + "_chooselabel";
                string api_version = Configuration.GetSection("api_version").Value;
                string redisCommonlyDevKey = isTest ? "test_room" + model.roomId + "_CommonlyDev_" + api_version : "room" + model.roomId + "_CommonlyDev_" + api_version;
                AppRedis.Del(redisKey);
                AppRedis.Del(redisKey2);
                AppRedis.Del(redisCommonlyDevKey);

            }

            return apiResult;
        }

        /// <summary>
        /// 资产删除（单个删除）
        /// </summary>
        [HttpPost]
        public async Task<TableData> Asset_Delete(AssetsDelete model)
        {
            TableData apiResult = new TableData();
            bool isManager = _app.CheckManager(model.user_id, model.customer_code);
            if (!isManager)
            {
                apiResult.Code = 500;
                apiResult.Message = "该用户不是资产管理员,无操作权限!";
                return apiResult;
            }
            if (model.assets_id <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择资产!";
                return apiResult;
            }

            var error_message = string.Empty;
             var result = _app.DeleteAssetsById(model.user_id, model.assets_id, out error_message);

            if (result)
            {
                if (model.room_id > 0)
                {
                    bool isTest = System.Convert.ToBoolean(Configuration.GetSection("IsTestEnvironment").Value);

                    string redisKey = isTest ? "test_room" + model.room_id + "_alldevs" : "room" + model.room_id + "_alldevs";
                    string api_version = Configuration.GetSection("api_version").Value;

                    string redisCommonlyDevKey = isTest ? "test_room" + model.room_id + "_CommonlyDev_" + api_version : "room" + model.room_id + "_CommonlyDev_" + api_version;
                    AppRedis.Del(redisKey);
                    AppRedis.Del(redisCommonlyDevKey);
                }
                apiResult.Data = "删除成功！";
                return apiResult;
            }
            else
            {
                return apiResult;

            }
        }
        /// <summary>
        /// 资产批量编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AssetsBatchEdit(AssetsBatchEditReq model)
        {
            TableData apiResult = new TableData();
            if (model.select_list.Count <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择需要编辑的资产!";
                return apiResult;
            }
            if (model.room_id != 0 && model.admin_user_id == 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择实验室资产管理员!";
                return apiResult;
            }
            if (model.is_open_maintain == 1)
            {
                if (model.assets_maintain_user.Count <= 0)
                {
                    apiResult.Code = 500;
                    apiResult.Message = "请添加资产保养人员!";
                    return apiResult;
                }
                if (string.IsNullOrWhiteSpace(model.maintain_matter))
                {
                    apiResult.Code = 500;
                    apiResult.Message = "请填写保养事项!";
                    return apiResult;
                }
            }
            var result = _app.AssetsBatchEdit(model);
            if (result.Code == 500)
            {
                apiResult.Code = 500;
                apiResult.Message = result.Message;
                return apiResult;

            }
            var roomIds = model.select_list.Select(c => c.room_id).Distinct().ToList();
            //清除缓存
            foreach (var item in roomIds)
            {
                bool isTest = System.Convert.ToBoolean(Configuration.GetSection("IsTestEnvironment").Value );
                string api_version = Configuration.GetSection("api_version").Value;
                string redisKey = isTest ? "test_room" + item + "_chooselabel" : "room" + item + "_chooselabel";
                string redisCommonlyDevKey = isTest ? "test_room" + item + "_CommonlyDev_" + api_version : "room" + item + "_CommonlyDev_" + api_version;

                AppRedis.Del(redisKey);
                AppRedis.Del(redisCommonlyDevKey);
            }
            apiResult.Data = result.Data;
            return apiResult;
        }

        /// <summary>
        /// 资产批量删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AssetsBatchDelete(List<AssetsBatchSelect> list, int user_id)
        {
            TableData apiResult = new TableData();
            if (list.Count <= 0)
            {
                apiResult.Code = 500;
                apiResult.Message = "请选择需要删除的资产!";
                return apiResult;
            }
            var result = _app.AssetsBatchDelete(list, user_id);
            if (result.Code == 500)
            {
                apiResult.Code = 500;
                apiResult.Message = result.Message;
                return apiResult;
            }
            var roomIds = list.Select(c => c.room_id).Distinct().ToList();
            //清除缓存
            foreach (var item in roomIds)
            {
     
                bool isTest = System.Convert.ToBoolean(Configuration.GetSection("IsTestEnvironment").Value);
                string api_version = Configuration.GetSection("api_version").Value;
                string all_assets_key = isTest ? "test_room" + item + "_alldevs" : "room" + item + "_alldevs";
                string redisKey = isTest ? "test_room" + item + "_chooselabel" : "room" + item + "_chooselabel";
                string redisCommonlyDevKey = isTest ? "test_room" + item + "_CommonlyDev_" + api_version : "room" + item + "_CommonlyDev_" + api_version;

                AppRedis.Del(all_assets_key);
                AppRedis.Del(redisKey);
                AppRedis.Del(redisCommonlyDevKey);
            }
            apiResult.Data = result.Data;
            return apiResult;
        }


        /// <summary>
        /// 获取资产分类列表(Web 共用)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetAssetsCategory(string customer_code)
        {
            TableData apiResult = new TableData();
            //string customer_code = UserData == null ? "" : (string.IsNullOrWhiteSpace(UserData.customer_code) == true ? "" : UserData.customer_code);
            var assetsCategoryList = _app.GetAllAssetsCategory(customer_code);
            var ParentList = assetsCategoryList.Where(c => c.parent_id == 0).OrderBy(c => c.sort_idx).ToList();
            List<ParentCategoryInfo> ParentCategoryList = new List<ParentCategoryInfo>();
            foreach (var item in ParentList)
            {
                ParentCategoryInfo pModel = new ParentCategoryInfo();
                pModel.id = item.id;
                pModel.name = item.name;
                pModel.parent_id = item.parent_id;
                pModel.childrebList = _app.GetChildrenAssetsCategory(item.id, assetsCategoryList);
                if (pModel.childrebList.Count() == 0)
                {
                    pModel.childrebList = null;
                }
                ParentCategoryList.Add(pModel);
            }
            apiResult.Data = ParentCategoryList;
            return apiResult;
        }

        /// <summary>
        /// 新增分类（Web 共用）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AddAssetsCategory(AddCategory model)
        {
            TableData apiResult = new TableData();
            var CategoryData = _app.GetAssetsCategoryByName(model.parent_id, model.name, model.customer_code);
            if (CategoryData != null)
            {
                apiResult.Code = 500;
                apiResult.Message = "分类名称已存在,无法重复添加!";
                return apiResult;
            }
            var result = _app.AddAssetsCategory(model.parent_id, model.name, model.customer_code);
            if (!result)
            {
                apiResult.Code = 500;
                return apiResult;
            }
            return apiResult;
        }

        /// <summary>
        /// 更新资产类别关联的属性
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> UpdateCategorySpecs(CategorySpecs model)
        {
            TableData apiResult = new TableData();
            bool isManager = _app.CheckManager(model.user_id, model.customer_code);
            if (!isManager)
            {
                apiResult.Code = 500;
                apiResult.Message = "该用户不是资产管理员,无操作权限!";
                return apiResult;
            }
            apiResult = _app.UpdateCategorySpecs(model.category_id, model.specIds);
           
            return apiResult;
        }

        /// <summary>
        /// 删除规格属性
        /// </summary>
        [HttpPost]
        public async Task<TableData> DeleteSpecs(DeleteSpecs model)
        {
            TableData apiResult = new TableData();
            bool isManager =_app.CheckManager(model.user_id, model.customer_code);
            if (!isManager)
            {
                apiResult.Code = 500;
                apiResult.Message = "该用户不是资产管理员,无操作权限!";
                return apiResult;
            }
            apiResult = _app.DeleteSpecs(model.customer_code, model.specIds);
            return apiResult;
        }

        /// <summary>
        /// 新增规格属性
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AddSpec(EditSpec model)
        {
            TableData apiResult = new TableData();
            bool isManager = _app.CheckManager(model.user_id, model.customer_code);
            if (!isManager)
            {
                apiResult.Message = "该用户不是资产管理员,无操作权限!";
                apiResult.Code = 500;
                return apiResult;
            }
            string msg = "";
            var result = _app.AddSpec(model.spec_name, model.customer_code, out msg);
            if (!result)
            {
                apiResult.Message = msg;
                apiResult.Code = 500;
                return apiResult;

            }
            apiResult.Data = msg;
            return apiResult;
        }
        #endregion


        [HttpGet]
        public void test()
        {
            var str = "153_stepDetail";
            var xxx = AppRedis.Get<string>(str);
            if (AppRedis.Exists(str))
                AppRedis.Del(str);
        }

    }
}