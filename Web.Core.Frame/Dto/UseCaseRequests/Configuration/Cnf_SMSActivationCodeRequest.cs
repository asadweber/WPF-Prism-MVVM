using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_SMSActivationCodeRequest : IUseCaseRequest<Cnf_SMSActivationCodeResponse>
    {
        public cnf_smsactivationcodeEntity Objcnf_smsactivationcode { get; }

        public Cnf_SMSActivationCodeRequest(cnf_smsactivationcodeEntity objcnf_smsactivationcode)
        {
            Objcnf_smsactivationcode = objcnf_smsactivationcode;
        }
    }
}
