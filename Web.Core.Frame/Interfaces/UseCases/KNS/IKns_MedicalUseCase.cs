using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_MedicalUseCase : IUseCaseRequestHandler<Kns_MedicalRequest, Kns_MedicalResponse>
    {
        Task<bool> Save(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);

        Task<bool> Update(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);

        Task<bool> Delete(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);


        Task<bool> GetSingle(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);

        Task<bool> GetAll(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);


        Task<bool> GetAllPaged(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);

        Task<bool> GetListView(Kns_MedicalRequest message, ICRUDRequestHandler<Kns_MedicalResponse> outputPort);
        
        
            
    }
}
