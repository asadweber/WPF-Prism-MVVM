using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandidateCertificateUseCase : IUseCaseRequestHandler<Gen_BatchCandidateCertificateRequest, Gen_BatchCandidateCertificateResponse>
    {
        Task<bool> Save(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);

        Task<bool> Update(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);

        Task<bool> Delete(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);


        Task<bool> GetSingle(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);

        Task<bool> GetAll(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);


        Task<bool> GetAllPaged(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);

        Task<bool> GetListView(Gen_BatchCandidateCertificateRequest message, ICRUDRequestHandler<Gen_BatchCandidateCertificateResponse> outputPort);
        
        
            
    }
}
