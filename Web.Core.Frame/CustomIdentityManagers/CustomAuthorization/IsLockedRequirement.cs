using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Linq;

namespace Web.Core.Frame.CustomAuthorization
{
    public class IsLockedRequirement : IAuthorizationRequirement
    {
        IHttpContextAccessor _contextAccessor;

        public async Task<bool> Pass(IHttpContextAccessor contextAccessor, AuthorizationHandlerContext context)
        {
            _contextAccessor = contextAccessor;
            return await Task.FromResult(context.User.Claims.Any(c => c.Type == "IsBlocked" && c.Value == "0"));
        }


    }

}
