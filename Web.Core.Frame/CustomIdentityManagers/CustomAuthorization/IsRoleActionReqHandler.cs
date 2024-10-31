using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;

namespace Web.Core.Frame.CustomAuthorization
{

    public class IsRoleActionReqHandler : AuthorizationHandler<IsRoleActionRequirement>
    {
        readonly IHttpContextAccessor _contextAccessor;

        public IsRoleActionReqHandler(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context,
            IsRoleActionRequirement locrequirement)
        {
            if (context.User == null)
            {
                context.Fail();
            }

            if (await locrequirement.Pass(_contextAccessor, context))
            {
                context.Succeed(locrequirement);
            }
        }
    }
}
