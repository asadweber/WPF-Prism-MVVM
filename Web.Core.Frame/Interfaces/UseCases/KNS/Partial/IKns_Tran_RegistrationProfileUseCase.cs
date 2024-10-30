using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
	public partial interface IKns_Tran_RegistrationProfileUseCase
	{
        Task<bool> GetAllProfileForMedical(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> GetAllProfileCustom(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
		Task<bool> GetAllProfileMultipleBasicId(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
		Task<bool> Report_registrationprofile(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> Report_registrationAllprofile(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
		Task<bool> Report_NeedServeDataReadyForMedical(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
		Task<bool> Report_DefaulterProfiles(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
        Task<bool> Report_NewDefaulterProfiles(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> Report_NeedServeDataReadyForMedicalStat(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> NeedServeRegisterData(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> MedicalResultStat(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> GetAllProfilePunishment(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
		Task<bool> Get_rpt_StudentProfile_Ext(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
		Task<bool> BasicProfile(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
        Task<bool> BasicProfileExt(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
        Task<bool> Report_BatchProfiles(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> kns_tran_getUnregisteredAjax(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> kns_tran_getUnregisteredAjaxByPageing(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


		Task<bool> kns_tran_getUnregisteredList(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> kns_tran_getAllRecruitsList(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> ValidateCivilIdUsingPaciCD(Kns_Tran_RegistrationProfileRequest message, IKns_Tran_RegistrationProfileHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


		Task<bool> GetProfileHistory(Kns_Tran_RegistrationProfileRequest message, IKns_Tran_RegistrationProfileHandler<Kns_Tran_RegistrationProfileResponse> outputPort);


		Task<bool> Getlast10DaysRegistrationStatictic(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> GetToDaysHistory(Kns_Tran_RegistrationProfileRequest message, IKns_Tran_RegistrationProfileHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        Task<bool> CheckRecruitDrivingLicence(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);



        Task<bool> Get_RecruitSituation_Report(Kns_Tran_RegistrationProfileRequest message, IKns_Tran_RegistrationProfileHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> Report_UnRegisterandLateRegPunishment(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

		Task<bool> Get_rpt_StudentProfile_ReportValidate(Kns_Tran_RegistrationProfileRequest message, IKns_Tran_RegistrationProfileHandler<Kns_Tran_RegistrationProfileResponse> outputPort);

        


    }
}
