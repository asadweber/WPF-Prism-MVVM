using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CertificateUseCase : IUseCaseRequestHandler<Gen_CertificateRequest, Gen_CertificateResponse>
    {
        Task<bool> Save(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        Task<bool> Update(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        Task<bool> Delete(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        Task<bool> GetSingle(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        Task<bool> GetAll(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        Task<bool> GetAllPaged(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        Task<bool> GetListView(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        Task<bool> GetDataForDropDown(Gen_CertificateRequest message, IDDLRequestHandler<Gen_CertificateResponse> outputPort);

    }
}
