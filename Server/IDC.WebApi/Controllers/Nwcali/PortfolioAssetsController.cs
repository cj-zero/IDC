using IDC.Application.Nwcali;
using IDC.Application.Nwcali.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Nwcali
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Nwcali")]
    public class PortfolioAssetsController : ControllerBase
    {
        private readonly PortfolioAssetsApp _app;
        public PortfolioAssetsController(PortfolioAssetsApp app)
        {
            _app = app;
        }
        /// <summary>
        /// 加载资产列表
        /// </summary>
        [HttpGet]
        public async Task<TableData> Load([FromQuery] QueryPortfolioAssetListReq request)
        {
            var result = new TableData();
            try
            {
                return await _app.Load(request);
            }
            catch (Exception ex)
            {

                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
                //Log.Logger.Error($"地址：{Request.Path}，参数：{request.ToJson()}, 错误：{result.Message}");
            }
            return result;
        }

        /// <summary>
        /// 加载组合资产详情
        /// </summary>
        [HttpGet]
        public async Task<TableData> GetDetails([FromQuery] int Id)
        {
            var result = new TableData();
            try
            {
                return await _app.GetDetails(Id);
            }
            catch (Exception ex)
            {

                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
               // Log.Logger.Error($"地址：{Request.Path}，参数：{Id}, 错误：{result.Message}");
            }
            return result;
        }

        /// <summary>
        ///  添加/修改组合资产
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Response> AddOrUpdate(AddOrUpdatePortfolioAssetsReq obj)
        {
            var result = new Response();
            try
            {
                result = await _app.AddOrUpdate(obj);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
                //Log.Logger.Error($"地址：{Request.Path}，参数：{obj.ToJson()}, 错误：{result.Message}");
            }

            return result;
        }
        /// <summary>
        /// 删除组合资产
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Response> Delete(int Id)
        {
            var result = new Response();
            try
            {
                await _app.Delete(Id);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
                //Log.Logger.Error($"地址：{Request.Path}，参数：{Id}, 错误：{result.Message}");
            }
            return result;
        }
    }
}
