using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_StatusChangeRequestUseCase
    {
        Task<bool> SearchProfile(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
        Task<bool> SearchProfileStatusChangeRequest(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
    }
}
