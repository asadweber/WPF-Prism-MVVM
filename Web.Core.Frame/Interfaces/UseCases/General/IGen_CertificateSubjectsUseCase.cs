using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CertificateSubjectsUseCase : IUseCaseRequestHandler<Gen_CertificateSubjectsRequest, Gen_CertificateSubjectsResponse>
    {
        Task<bool> Save(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> Update(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> Delete(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);


        Task<bool> GetSingle(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> GetAll(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> GetListView(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);
        
        
            
    }
}
