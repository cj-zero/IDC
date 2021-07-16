using IDC.Application.Production;
using IDC.Application.Production.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Production
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Production")]
    public class ProductionController : ControllerBase
    {
        private ProductionApp _app;
        public ProductionController(ProductionApp app)
        {
            _app = app;
        }

        /// <summary>
        /// 获取生产订单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetProductionList([FromQuery] QueryProductionList req)
        {
            try
            {
                return await _app.GetProductionList(req);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 获取工单发料信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetStoreOwtrList([FromQuery] QueryProductionList req)
        {

            try
            {
                return await _app.GetStoreOwtrList(req);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
