using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Gen_CertificateUseCase : IUseCaseRequestHandler<Kns_Gen_CertificateRequest, Kns_Gen_CertificateResponse>
    {
        Task<bool> Save(Kns_Gen_CertificateRequest message, ICRUDRequestHandler<Kns_Gen_CertificateResponse> outputPort);

        Task<bool> Update(Kns_Gen_CertificateRequest message, ICRUDRequestHandler<Kns_Gen_CertificateResponse> outputPort);

        Task<bool> Delete(Kns_Gen_CertificateRequest message, ICRUDRequestHandler<Kns_Gen_CertificateResponse> outputPort);


        Task<bool> GetSingle(Kns_Gen_CertificateRequest message, ICRUDRequestHandler<Kns_Gen_CertificateResponse> outputPort);

        Task<bool> GetAll(Kns_Gen_CertificateRequest message, ICRUDRequestHandler<Kns_Gen_CertificateResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Gen_CertificateRequest message, ICRUDRequestHandler<Kns_Gen_CertificateResponse> outputPort);

        Task<bool> GetListView(Kns_Gen_CertificateRequest message, ICRUDRequestHandler<Kns_Gen_CertificateResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Gen_CertificateRequest message, IDDLRequestHandler<Kns_Gen_CertificateResponse> outputPort);
    
    }
}
