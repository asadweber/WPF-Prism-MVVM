using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;

namespace Web.Core.Frame.Interfaces.Services
{
    public partial interface IHttpClientHR
    {
        Task<string> CheckUserExists(string adUserAccountName);

        Task<string> LoginToHRAPIService();

        Task<string> GetMilitaryShortProfileFromHR(string email, string apitoken = "");


        Task<bool> LDAPAuthentication(string userName, string password);

        Task<string> GetHRAPITokenFromClaim();

        Task<string> GetReportingReceiverListByModule(string adEmail, int moduleId, string hrTokenJsonString);

    }
   
}
