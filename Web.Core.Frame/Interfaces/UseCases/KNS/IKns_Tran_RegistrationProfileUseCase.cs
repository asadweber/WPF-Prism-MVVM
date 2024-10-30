using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegistrationProfileUseCase : IUseCaseRequestHandler<Kns_Tran_RegistrationProfileRequest, Kns_Tran_RegistrationProfileResponse>
    {
        Task<bool> Save(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> Update(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> Delete(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


        Task<bool> GetDataForDropDown(Kns_Tran_RegistrationProfileRequest message, IDDLRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
        Task<bool> GetDataForDropDownByBatch(Kns_Tran_RegistrationProfileRequest message, IDDLRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


        

    }
}
