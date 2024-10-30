using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Web.Core.Frame.Interfaces.Services;

namespace Web.Core.Frame.CustomAuthorization
{

    public class IsRoleActionReqHandler : AuthorizationHandler<IsRoleActionRequirement>
    {
        readonly IHttpContextAccessor _contextAccessor;
        readonly IConfiguration _configuration;

        private readonly IJwtTokenValidator _iJwtTokenValidator;

        public IsRoleActionReqHandler(
            IHttpContextAccessor contextAccessor,
            IConfiguration configuratio,
            IJwtTokenValidator iJwtTokenValidator)
        {
            _contextAccessor = contextAccessor;
            _configuration = configuratio;
            _iJwtTokenValidator = iJwtTokenValidator;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context,
            IsRoleActionRequirement locrequirement)
        {
            if (context.User == null)
            {
                context.Fail();
            }

            if (await locrequirement.Pass(_contextAccessor, _configuration, context, _iJwtTokenValidator))
            {
                context.Succeed(locrequirement);
            }
        }
    }
}
