using IDC.Application.PurchaseOrder;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.PurchaseOrder
{
    /// <summary>
    /// 采购订单
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "PurchaseOrder")]
    public class PurchaseOrderController: ControllerBase
    {
        private readonly PurchaseOrderApp _app;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public PurchaseOrderController(PurchaseOrderApp app)
        {
            _app= app;
        }
        /// <summary>
        /// 根据采购单号获取采购单信息
        /// </summary>
        /// <param name="docentry">采购单号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetPurchaseOrderList(string docentry)
        {
            return await _app.GetPurchaseOrderList(docentry);
        }
        /// <summary>
        /// 根据采购单获取收货单
        /// </summary>
        /// <param name="docentry">采购单号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetOpdnByOpor(string docentry)
        {
            return await _app.GetOpdnByOpor(docentry);
        }
    }
}
