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
    public class SalesDeliveryController:ControllerBase
    {
        private readonly SalesDeliveryApp _saleDeliveryApp;
        private readonly StockTransferApp _stockTransferApp;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="app"></param>
        public SalesDeliveryController(SalesDeliveryApp app, StockTransferApp sApp)
        {
            _saleDeliveryApp = app;
            _stockTransferApp = sApp;
        }

        /// <summary>
        /// 同步销售交货
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AddSalesDelivery(AddOrUpdSalesDeliveryReq Obj)
        {
            var result = new TableData();
            try
            {
                result = await _saleDeliveryApp.SalesDeliveryHandle(Obj);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 根据制造商序列号获取序列号信息
        /// </summary>
        /// <param name="MnfSerialNo">制造商序列号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetSerialInfoByMnfSearialNo(string MnfSerialNo)
        {
            var result = new TableData();
            try
            {
                result = await _saleDeliveryApp.GetSerialInfoByMnfSearialNo(MnfSerialNo);
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
