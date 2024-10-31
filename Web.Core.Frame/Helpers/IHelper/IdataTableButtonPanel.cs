using AppConfig.HelperClasses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Web.Core.Frame.Helpers.IHelper
{
    public interface IdataTableButtonPanel
    {
        Task<string> genDTBtnPanel<T>(string controllerName, T primaryKey, string primaryKeyName, ClaimsIdentity claimsIdentity,
           List<dataTableButtonModel> btnActionList, IHttpContextAccessor contextAccessor = null);
    }
}
