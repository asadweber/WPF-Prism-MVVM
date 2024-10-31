using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_SMSActivationTransectionRequest : IUseCaseRequest<Cnf_SMSActivationTransectionResponse>
    {
        public cnf_smsactivationtransectionEntity Objcnf_smsactivationtransection { get; }

        public Cnf_SMSActivationTransectionRequest(cnf_smsactivationtransectionEntity objcnf_smsactivationtransection)
        {
            Objcnf_smsactivationtransection = objcnf_smsactivationtransection;
        }
    }
}
