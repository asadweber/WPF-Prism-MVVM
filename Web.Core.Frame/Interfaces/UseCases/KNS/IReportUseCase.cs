using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
	public partial interface IReportUseCase
	{
		Task<bool> Report_registrationprofile(Kns_Tran_RegistrationProfileRequest message, ICRUDRequestHandler<Kns_Tran_RegistrationProfileResponse> outputPort);
		
	}
}
