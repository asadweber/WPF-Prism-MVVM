using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ApiModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;

namespace Web.Core.Frame.Interfaces.Services
{
    public partial interface IHttpClientHR
    {
        #region Organization And Position API
        Task<string> GetAllAuthority();
        Task<string> GetDirectorateByAuthority(long authorityId);
        Task<string> GetParentOrganization(long? entityKey);
        Task<string> GetOrganization(long? entityKey, string keyEntityName);
        Task<string> GetAllPosition();
        Task<string> GetOrganizationWiseAssignPosition(long? entityKey);
        Task<stp_organizationentityEntity> GetAuthorityLogo(long? entityKey);
        Task<string> GetOrganizationPositionHierarchy(long? entityKey);
        Task<string> GetOrganizationPositionHierarchyIncludingChild(long? entityKey);
        Task<gen_militarypossitionEntity> GetAllPositionByPage(int? pageNum, int? pageSize, string search);
        Task<gen_militarypossitionEntity> GetAllPositionById(long positionId);

        #endregion
    }
   
}
