using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CertificateLevelUseCase : IUseCaseRequestHandler<Gen_CertificateLevelRequest, Gen_CertificateLevelResponse>
    {
        Task<bool> Save(Gen_CertificateLevelRequest message, ICRUDRequestHandler<Gen_CertificateLevelResponse> outputPort);

        Task<bool> Update(Gen_CertificateLevelRequest message, ICRUDRequestHandler<Gen_CertificateLevelResponse> outputPort);

        Task<bool> Delete(Gen_CertificateLevelRequest message, ICRUDRequestHandler<Gen_CertificateLevelResponse> outputPort);


        Task<bool> GetSingle(Gen_CertificateLevelRequest message, ICRUDRequestHandler<Gen_CertificateLevelResponse> outputPort);

        Task<bool> GetAll(Gen_CertificateLevelRequest message, ICRUDRequestHandler<Gen_CertificateLevelResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CertificateLevelRequest message, ICRUDRequestHandler<Gen_CertificateLevelResponse> outputPort);

        Task<bool> GetListView(Gen_CertificateLevelRequest message, ICRUDRequestHandler<Gen_CertificateLevelResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CertificateLevelRequest message, IDDLRequestHandler<Gen_CertificateLevelResponse> outputPort);
    
    }
}
