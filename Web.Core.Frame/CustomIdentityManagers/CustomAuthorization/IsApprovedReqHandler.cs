using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;

namespace Web.Core.Frame.CustomAuthorization
{

    public class IsApprovedReqHandler : AuthorizationHandler<IsApprovedRequirement>
    {
        readonly IHttpContextAccessor _contextAccessor;

        public IsApprovedReqHandler(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, 
            IsApprovedRequirement apprequirement)
        {
            if (context.User == null)
            {
                context.Fail();
            }

            if (await apprequirement.Pass(_contextAccessor, context))
            {
                context.Succeed(apprequirement);
            }


            //if (await approverequirement.Pass(_contextAccessor, context))
            //{
            //    context.Succeed(locrequirement);
            //}

            //if (context.Resource is AuthorizationFilterContext filterContext)
            //{
            //    var area = (filterContext.RouteData.Values["area"] as string)?.ToLower();
            //    var controller = (filterContext.RouteData.Values["controller"] as string)?.ToLower();
            //    var action = (filterContext.RouteData.Values["action"] as string)?.ToLower();
            //    var id = (filterContext.RouteData.Values["id"] as string)?.ToLower();


               
            //}
            //if (context.Resource is DefaultHttpContext httpContext)
            //{
            //    var area = httpContext.Request.RouteValues["area"].ToString();
            //    var controller = httpContext.Request.RouteValues["controller"].ToString();
            //    var action = httpContext.Request.RouteValues["action"].ToString();
            //    var id = httpContext.Request.RouteValues["id"].ToString();
            //    if (await requirement.Pass(_contextAccessor, area, controller, action, id))
            //    {
            //        context.Succeed(requirement);
            //    }
            //}
            //if (context.Resource is Endpoint endpoint)
            //{
            //    context.Succeed(requirement);
            //}
        }
    }
}
