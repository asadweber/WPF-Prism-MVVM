using BDO.Core.Base;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using Web.Core.Frame.Interfaces.Services;

namespace WebApi.Extensions
{
    /// <summary>
    /// ApiSecurityFillerAttribute
    /// </summary>
    public class ApiSecurityFillerAttribute : IActionFilter
    {

        private readonly IJwtTokenValidator _jwtTokenValidator;

        /// <summary>
        /// ApiSecurityFillerAttribute
        /// </summary>
        /// <param name="jwtTokenHandler"></param>
        /// <param name="jwtTokenValidator"></param>
        /// <param name="config"></param>
        public ApiSecurityFillerAttribute(
            IJwtTokenValidator jwtTokenValidator)
        {
            //_jwtTokenHandler = jwtTokenHandler ?? throw new ArgumentNullException(nameof(jwtTokenHandler));
            _jwtTokenValidator = jwtTokenValidator ?? throw new ArgumentNullException(nameof(jwtTokenValidator));
            // _config = config ?? throw new ArgumentNullException(nameof(config)); ;
        }


        /// <summary>
        /// OnActionExecuted
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        /// <summary>
        /// OnActionExecuting
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //if (context.ModelState.IsValid)
            //{
            var actionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
            var actionName = actionDescriptor.ActionName;
            var controllerName = actionDescriptor.ControllerName;
            if (actionName == "ApiLogin")
            {
                return;
            }

            string Token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (context.ActionArguments.Count > 0 && Token != null)
            {
                var cp = _jwtTokenValidator.GetPrincipalFromToken(Token);
                if (cp != null)
                {
                    if (!context.ActionArguments.Keys.Contains("request"))
                        return;

                    var id = cp.Claims.First(c => c.Type == "id").Value;
                    var username = cp.Claims.First(c => c.Type == "CreatedByUserName").Value;
                    var transid = cp.Claims.First(c => c.Type == "TransID").Value;
                    DateTime dt = DateTime.Now;
                    SecurityCapsule objBase = ((BDO.Core.Base.BaseEntity)context.ActionArguments["request"])?.BaseSecurityParam;
                    if (objBase == null)
                        objBase = new SecurityCapsule();
                    objBase.actioname = actionName;
                    objBase.controllername = controllerName;
                    objBase.createdbyusername = username;
                    objBase.updatedbyusername = username;
                    objBase.ipaddress = context.HttpContext.Connection.RemoteIpAddress?.ToString() ?? "127.0.0.1";
                    objBase.createddate = dt;
                    objBase.updateddate = dt;
                    objBase.transid = transid;
                    ((BDO.Core.Base.BaseEntity)context.ActionArguments["request"]).BaseSecurityParam = objBase;
                }
            }
            
            return;
        }


    }
}
