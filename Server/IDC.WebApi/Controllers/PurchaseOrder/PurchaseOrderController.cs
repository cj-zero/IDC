using IDC.Application.PurchaseOrder;
using IDC.Application.SapHandler.Request;
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

        /// <summary>
        /// 获取仓库列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetStoreOwhsList(string key="")
        {
            return await _app.GetStoreOwhsList(key);
        }

        /// <summary>
        /// 根据passport_id获取用户信息
        /// </summary>
        /// <param name="passport_id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetUserInfoByPassportId(int passport_id)
        {
            return await _app.GetUserInfoByPassportId(passport_id);
        }

        /// <summary>
        /// 创建并提交库存转储
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> StockTransferSave(StockTransferReq req)
        {
            return await _app.StockTransferSave(req);
        }

        /// <summary>
        /// 审批库存转储单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> Approval(ApprovalReq req)
        {
            return await _app.Approval(req);
        }

        /// <summary>
        /// 查询转储申请单审批结果
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetStockTransferResult(string req)
        {
            return await _app.GetStockTransferResult(req);
        }
    }
}
