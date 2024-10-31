using BDO.Core.Base;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using Web.Core.Frame.Interfaces.Services;
using Microsoft.AspNetCore.Http.Extensions;

namespace WebApi.Extensions
{
    /// <summary>
    /// ApiSecurityFillerAttribute
    /// </summary>
    public class ApiSecurityFillerAttribute : IActionFilter
    {

        private readonly IHostingEnvironment _HostingEnvironment;
        private readonly IJwtTokenValidator _jwtTokenValidator;

        /// <summary>
        /// ApiSecurityFillerAttribute
        /// </summary>
        /// <param name="jwtTokenHandler"></param>
        /// <param name="jwtTokenValidator"></param>
        /// <param name="config"></param>
        public ApiSecurityFillerAttribute(
            IHostingEnvironment HostingEnvironment,
            IJwtTokenValidator jwtTokenValidator)
        {
            //_jwtTokenHandler = jwtTokenHandler ?? throw new ArgumentNullException(nameof(jwtTokenHandler));
            _jwtTokenValidator = jwtTokenValidator ?? throw new ArgumentNullException(nameof(jwtTokenValidator));
            _HostingEnvironment = HostingEnvironment;
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
            if (actionName == "ApiLogin" || actionName == "SubscribeCivilIDRequests")
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
                    objBase.ipaddress = GetUserIP(context);
                    objBase.createddate = dt;
                    objBase.updateddate = dt;
                    objBase.transid = transid;
                    ((BDO.Core.Base.BaseEntity)context.ActionArguments["request"]).BaseSecurityParam = objBase;
                }
            }
            else
            {
                if (_HostingEnvironment.IsDevelopment())
                {
                    //THIS IS MOCK, REMOVE WHEN PUBLISH. COS WITHOUT SECURITY ACCESS TOKEN IT SHOULD NOT WORK!!!
                    DateTime dt = DateTime.Now;
                    bool reqobject = false;
                    SecurityCapsule objBase = null;
                    if (objBase == null)
                        objBase = new SecurityCapsule();
                    if (context.ActionArguments.Count > 0)
                    {
                        objBase = ((BDO.Core.Base.BaseEntity)context.ActionArguments["request"])?.BaseSecurityParam;
                        if (objBase == null)
                            objBase = new SecurityCapsule();
                        reqobject = true;
                    }
                    else
                    {
                        reqobject = false;
                    }

                    if (objBase != null)
                    {
                        objBase.actioname = actionName;
                        objBase.controllername = controllerName;
                        objBase.createdbyusername = "e527c07f-de86-44c6-9f93-0000800d295a";
                        objBase.updatedbyusername = "e527c07f-de86-44c6-9f93-0000800d295a";
                        objBase.ipaddress = GetUserIP(context); 
                        objBase.createddate = dt;
                        objBase.updateddate = dt;
                        objBase.transid = "DUMMYTRANSID";
                        if (reqobject)
                            ((BDO.Core.Base.BaseEntity)context.ActionArguments["request"]).BaseSecurityParam = objBase;
                        else
                            context.ActionArguments.Add("request", objBase);
                    }
                }
            }
            return;
        }

        /// <summary>
        /// GetUserIP
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public string GetUserIP(ActionExecutingContext context)
        {
            var ip = context.HttpContext.Connection.RemoteIpAddress?.ToString();
            ip = (string.IsNullOrEmpty(context.HttpContext.Request.Headers["X-Forwarded-For"]) != true && context.HttpContext.Request.Headers["X-Forwarded-For"] != "")
                ? context.HttpContext.Request.Headers["X-Forwarded-For"] : context.HttpContext.Request.Headers["REMOTE_ADDR"];
            return ip;
        }
    }
}
