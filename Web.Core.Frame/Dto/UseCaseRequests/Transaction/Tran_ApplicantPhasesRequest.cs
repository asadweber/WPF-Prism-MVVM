using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Transaction
{
    public partial class Tran_ApplicantPhasesRequest : IUseCaseRequest<Tran_ApplicantPhasesResponse>
    {
        public tran_applicantphasesEntity Objtran_applicantphases { get; }

        public Tran_ApplicantPhasesRequest(tran_applicantphasesEntity objtran_applicantphases)
        {
            Objtran_applicantphases = objtran_applicantphases;
        }
    }
}
