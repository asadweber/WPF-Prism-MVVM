using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegistrationProfileUseCase 
    {
        Task<bool> Registration(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        
        
        Task<bool> LoginWithPACI(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
        Task<bool> LoginWithUserPassword(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);



        Task<bool> UpdateProfileData(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


        Task<bool> UpdateProfileDataSingle(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


        Task<bool> Update_RegistrationEmergencySingle(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> Update_RegistrationEducationSingle(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> BackOfficeRegistrationByAdmin(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


        Task<bool> SaveProfilePaciDataForSync(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

    }
}
