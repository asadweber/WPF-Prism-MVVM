using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_Search_ParametersRequest : IUseCaseRequest<Gen_Search_ParametersResponse>
    {
        public gen_search_parametersEntity Objgen_search_parameters { get; }
        
        public Gen_Search_ParametersRequest(gen_search_parametersEntity objgen_search_parameters)
        {
            Objgen_search_parameters = objgen_search_parameters;
        }
    }
}
