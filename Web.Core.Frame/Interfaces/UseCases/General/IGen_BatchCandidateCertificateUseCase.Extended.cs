using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandidateCertificateUseCase : IUseCaseRequestHandler<Gen_BatchCandidateCertificateRequest, Gen_BatchCandidateCertificateResponse>
    {
        Task<bool> GetSingleExt(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);
        Task<bool> GetListViewExt(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);
        Task<bool> SaveList(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);
    }
}
