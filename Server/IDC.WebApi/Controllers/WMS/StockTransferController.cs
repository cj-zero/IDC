using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IDC.Application.WMS;
using IDC.Application.WMS.Request;
using IDC.Infrastructure.Returned;

namespace IDC.WebApi.Controllers.WMS
{
    [Route("api/WMS/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "WMS")]
    public class StockTransferController : ControllerBase
    {
        private readonly StockTransferApp _stockTransferApp;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="app"></param>
        public StockTransferController(StockTransferApp app)
        {
            _stockTransferApp = app;
        }
       
        /// <summary>
        /// 同步库存转储
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AddStockTransfer(AddOrUpdStockTransferReq obj)
        {
            var result = new TableData();
            try
            {
                result = await _stockTransferApp.StockTransferHandle(obj);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
