using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Core.Frame.Dto;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface IJwtFactory
    {
        Task<AccessToken> GenerateEncodedToken(owin_userEntity user, List<string> userrole, string hrTokenJsonString = null, string hrprofileJsonString = null);
        string GenerateToken(int size = 32);
    }
}
