using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CertificateTypeUseCase : IUseCaseRequestHandler<Gen_CertificateTypeRequest, Gen_CertificateTypeResponse>
    {
        Task<bool> Save(Gen_CertificateTypeRequest message, ICRUDRequestHandler<Gen_CertificateTypeResponse> outputPort);

        Task<bool> Update(Gen_CertificateTypeRequest message, ICRUDRequestHandler<Gen_CertificateTypeResponse> outputPort);

        Task<bool> Delete(Gen_CertificateTypeRequest message, ICRUDRequestHandler<Gen_CertificateTypeResponse> outputPort);


        Task<bool> GetSingle(Gen_CertificateTypeRequest message, ICRUDRequestHandler<Gen_CertificateTypeResponse> outputPort);

        Task<bool> GetAll(Gen_CertificateTypeRequest message, ICRUDRequestHandler<Gen_CertificateTypeResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CertificateTypeRequest message, ICRUDRequestHandler<Gen_CertificateTypeResponse> outputPort);

        Task<bool> GetListView(Gen_CertificateTypeRequest message, ICRUDRequestHandler<Gen_CertificateTypeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CertificateTypeRequest message, IDDLRequestHandler<Gen_CertificateTypeResponse> outputPort);
    
    }
}
