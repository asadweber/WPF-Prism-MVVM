using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegistrationProfileFileStorageUseCase : IUseCaseRequestHandler<Kns_Tran_RegistrationProfileFileStorageRequest, Kns_Tran_RegistrationProfileFileStorageResponse>
    {
        Task<bool> Save(Kns_Tran_RegistrationProfileFileStorageRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileFileStorageResponse> outputPort);

        Task<bool> Update(Kns_Tran_RegistrationProfileFileStorageRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileFileStorageResponse> outputPort);

        Task<bool> Delete(Kns_Tran_RegistrationProfileFileStorageRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileFileStorageResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_RegistrationProfileFileStorageRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileFileStorageResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_RegistrationProfileFileStorageRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileFileStorageResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_RegistrationProfileFileStorageRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileFileStorageResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_RegistrationProfileFileStorageRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileFileStorageResponse> outputPort);
        
        
            
    }
}
