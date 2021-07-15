using IDC.Application;
using IDC.Application.Common;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace IDC.WebApi.Global
{
    /// <summary>
    /// 行为过滤器
    /// </summary>
    /// <param name="context"></param>
    public class ActionFilter : IActionFilter
    {
        private readonly IAuth _auth;
        public ActionFilter(IAuth auth) 
        {
            _auth = auth;
        }
        /// <summary>
        /// 行为前
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var description =
                (Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor;

            var Controllername = description.ControllerName.ToLower();
            var Actionname = description.ActionName.ToLower();

            //匿名标识
            var authorize = description.MethodInfo.GetCustomAttribute(typeof(AllowAnonymousAttribute));
            if (authorize != null)
            {
                return;
            }
            
            if (_auth.CheckLogin())
            {
                context.HttpContext.Response.StatusCode = 401;
                context.Result = new JsonResult(new Response
                {
                    Code = 401,
                    Message = "认证失败，请提供认证信息"
                });
            }
        }
        /// <summary>
        /// 行为后
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }
        
    }
}
