using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Transaction
{
    public partial class Tran_SpecialRegistrationRequest : IUseCaseRequest<Tran_SpecialRegistrationResponse>
    {
        public tran_specialregistrationEntity Objtran_specialregistration { get; }

        public Tran_SpecialRegistrationRequest(tran_specialregistrationEntity objtran_specialregistration)
        {
            Objtran_specialregistration = objtran_specialregistration;
        }
    }
}
