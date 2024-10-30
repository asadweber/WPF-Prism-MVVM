using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_MedicalUseCase
    {
        Task<bool> MedicalResultData(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);

            
    }
}
