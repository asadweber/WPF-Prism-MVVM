using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Gen_CertificateSubjectsUseCase : IUseCaseRequestHandler<Kns_Gen_CertificateSubjectsRequest, Kns_Gen_CertificateSubjectsResponse>
    {
        Task<bool> Save(Kns_Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> Update(Kns_Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> Delete(Kns_Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);


        Task<bool> GetSingle(Kns_Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> GetAll(Kns_Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);

        Task<bool> GetListView(Kns_Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Gen_CertificateSubjectsRequest message, IDDLRequestHandler<Kns_Gen_CertificateSubjectsResponse> outputPort);
    
    }
}
