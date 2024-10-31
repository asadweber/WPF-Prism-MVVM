using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_StudentMenuSkipRequest : IUseCaseRequest<Cnf_StudentMenuSkipResponse>
    {
        public cnf_studentmenuskipEntity Objcnf_studentmenuskip { get; }

        public Cnf_StudentMenuSkipRequest(cnf_studentmenuskipEntity objcnf_studentmenuskip)
        {
            Objcnf_studentmenuskip = objcnf_studentmenuskip;
        }
    }
}
