using IDC.Application.SapHandler;
using IDC.Application.SapHandler.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Handler
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Handler")]
    public class HandlerController : ControllerBase
    {
        private readonly HandlerApp _handlerApp;

        public HandlerController(HandlerApp handlerApp) 
        {
            _handlerApp = handlerApp;
        }
        /// <summary>
        /// 同步采购收货
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> Rcvddetail(RcvddetailReq model) 
        {
            return await _handlerApp.Rcvddetail(model);
        }

        /// <summary>
        /// 同步运输采购订单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> AddTransPurchaseOrder(AddPurchaseOrderReq model)
        {
            return await _handlerApp.AddTransPurchaseOrder(model);
        }

        /// <summary>
        /// 修改运输采购订单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> UpdateTransPurchaseOrder(AddPurchaseOrderReq model)
        {
            return await _handlerApp.UpdateTransPurchaseOrder(model);
        }

        /// <summary>
        /// 创建并提交库存转储
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> StockTransferSave(StockTransferReq req)
        {
            return await _handlerApp.StockTransferSave(req);
        }

        /// <summary>
        /// 审批库存转储单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> Approval(ApprovalReq req)
        {
            return await _handlerApp.Approval(req);
        }
    }
}
