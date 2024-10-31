using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Security.Claims;
using System.Threading;

namespace Web.Core.Frame.CustomAuthorization
{
    public class IsRoleActionRequirement : IAuthorizationRequirement
    {
        IHttpContextAccessor _contextAccessor;

        public async Task<bool> Pass(IHttpContextAccessor contextAccessor, AuthorizationHandlerContext context)
        {
            _contextAccessor = contextAccessor;
            string strRoles = string.Empty;
            CancellationToken cancellationToken = new CancellationToken();

            if (context.Resource is Endpoint endpoint)
            {
                var cad = endpoint.Metadata.OfType<ControllerActionDescriptor>().FirstOrDefault();
                if (endpoint.DisplayName.ToUpper().Contains("HUB") && cad == null)
                {
                    return await Task.FromResult(true);
                }

                if (cad != null)
                {
                    var controllerFullName = cad.ControllerTypeInfo.Name.Substring(0, cad.ControllerTypeInfo.Name.Length - 10);
                    var actionName = cad.ActionName;
                    var roleClaims = context.User.Claims.Where(c => c.Type == ClaimTypes.Role)?.ToList();
                    if (roleClaims != null && roleClaims.Count > 0)
                    {
                        strRoles = string.Join(",", roleClaims.Select(x => x.Value).ToArray());
                        var obj = await BFC.Core.FacadeCreatorObjects.Security.owin_rolepermissionFCC.GetFacadeCreate(contextAccessor).GetRolesPermissionByParams(new BDO.Core.DataAccessObjects.SecurityModels.owin_rolepermissionExtEntity()
                        {
                            code = strRoles,
                            ControllerName = controllerFullName + "/" + actionName
                        }, cancellationToken);
                        return await Task.FromResult(obj == null ? false : true);
                    }
                }
                else
                    return await Task.FromResult(false);
            }

            if (context.Resource is AuthorizationFilterContext filterContext)
            {
                return await Task.FromResult(true);
            }

            if (context.Resource is DefaultHttpContext httpContext)
            {
                return await Task.FromResult(true);
            }


            return await Task.FromResult(false);
        }


    }

}
