using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using IDC.Infrastructure.Returned;
using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;
using IDC.Application.SSO;

namespace IDC.WebApi.Global
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private ILogger<GlobalExceptionFilter> _logger;
        private IAuth auth;

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> _logger, IAuth auth)
        {
            this._logger = _logger;
            this.auth = auth;
        }

        public void OnException(ExceptionContext context)
        {
            // 如果异常没有被处理则进行处理
            if (context.ExceptionHandled == false)
            {
                //日志入库
                Exception ex = context.Exception;

                //报错地址
                string url = context.HttpContext.Request.Host+"/"+context.HttpContext.Request.Path;
                //报错参数
                string parameter = context.HttpContext.Request.QueryString.ToString();
                //报错请求方式
                string method = context.HttpContext.Request.Method.ToString();
                var userObj=auth.GetCurrentUser();
                //写入日志
                _logger.LogError($"操作人:{userObj.Account}报错地址:{url},请求方式：{method},参数:{parameter},异常描述：{ex.Message},堆栈信息：{ex.StackTrace}");
                //定义返回信息
                Response res = new Response();
                if (new Regex("^[\u4E00-\u9FA5\u3002|\uff1f|\uff01|\uff0c|\u3001|\uff1b|\uff1a|\u201c|\u201d|\u2018|\u2019|\uff08|\uff09|\u300a|\u300b|\u3008|\u3009|\u3010|\u3011|\u300e|\u300f|\u300c|\u300d|\ufe43|\ufe44|\u3014|\u3015|\u2026|\u2014|\uff5e|\ufe4f|\uffe5]{0,}$").IsMatch(ex.Message))
                {
                    res.Message = ex.Message;
                }
                else 
                {
                    res.Message = "网络不稳定，请稍后重试";
                }
                res.Code = 500;
               
                context.Result = new ContentResult
                {
                    // 返回状态码设置为200，表示成功
                    StatusCode = StatusCodes.Status500InternalServerError,
                    // 设置返回格式
                    ContentType = "application/json;charset=utf-8",
                    Content = JsonConvert.SerializeObject(res)
                };
            }
            // 设置为true，表示异常已经被处理了
            context.ExceptionHandled = true;

        }
    }
}
