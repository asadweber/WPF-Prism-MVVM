using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ResidentTypeUseCase : IUseCaseRequestHandler<Gen_ResidentTypeRequest, Gen_ResidentTypeResponse>
    {
        
        Task<bool> GetResidentTypeDataForDropDown(Gen_ResidentTypeRequest message, IDDLRequestHandler<Gen_ResidentTypeResponse> outputPort);

    }
}
