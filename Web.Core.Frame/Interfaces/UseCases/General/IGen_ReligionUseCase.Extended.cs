using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ReligionUseCase : IUseCaseRequestHandler<Gen_ReligionRequest, Gen_ReligionResponse>
    {
        Task<bool> GetReligionDataForDropDown(Gen_ReligionRequest message, IDDLRequestHandler<Gen_ReligionResponse> outputPort);

    }
}
