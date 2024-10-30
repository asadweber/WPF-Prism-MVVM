using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_RegistrationProfileRequest : IUseCaseRequest<Kns_Tran_RegistrationProfileResponse>
    {
        public kns_tran_registrationprofileEntity Objkns_tran_registrationprofile { get; }

		public kns_tran_registrationprofileHistoryEntity Objkns_tran_registrationprofileHistory { get; }


		public Kns_Tran_RegistrationProfileRequest(kns_tran_registrationprofileEntity objkns_tran_registrationprofile)
        {
            Objkns_tran_registrationprofile = objkns_tran_registrationprofile;
        }

		public Kns_Tran_RegistrationProfileRequest(kns_tran_registrationprofileHistoryEntity objkns_tran_registrationprofile)
		{
			Objkns_tran_registrationprofileHistory = objkns_tran_registrationprofile;
		}
	}
}
