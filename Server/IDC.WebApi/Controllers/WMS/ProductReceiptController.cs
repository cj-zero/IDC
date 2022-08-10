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
    public class ProductReceiptController : ControllerBase
    {
        private readonly ProductReceiptApp _productReceiptApp;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="app"></param>
        public ProductReceiptController(ProductReceiptApp app)
        {
            _productReceiptApp = app;
        }
        /// <summary>
        /// 同步生产收货
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AddProductReceipt(AddOrUpdProductReceiptReq obj)
        {
            var result = new TableData();
            try
            {
                result = await _productReceiptApp.ProductReceiptHandle(obj);//
                //result = await _productReceiptApp.ProductReceiptHandleERP3(obj.DocNum);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 获取生产订单可收货数量
        /// </summary>
        /// <param name="ProductNo">生产单号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> ProductReceiptValidQty(int ProductNo)
        {
            var result = new TableData();
            try
            {
                result = await _productReceiptApp.ProductReceiptValidQty(ProductNo);
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
