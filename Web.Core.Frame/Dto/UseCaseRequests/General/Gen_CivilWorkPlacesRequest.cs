using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CivilWorkPlacesRequest : IUseCaseRequest<Gen_CivilWorkPlacesResponse>
    {
        public gen_civilworkplacesEntity Objgen_civilworkplaces { get; }
        
        public Gen_CivilWorkPlacesRequest(gen_civilworkplacesEntity objgen_civilworkplaces)
        {
            Objgen_civilworkplaces = objgen_civilworkplaces;
        }
    }
}
