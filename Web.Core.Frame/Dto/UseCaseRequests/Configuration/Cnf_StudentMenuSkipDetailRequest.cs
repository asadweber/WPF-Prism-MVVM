using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_StudentMenuSkipDetailRequest : IUseCaseRequest<Cnf_StudentMenuSkipDetailResponse>
    {
        public cnf_studentmenuskipdetailEntity Objcnf_studentmenuskipdetail { get; }

        public Cnf_StudentMenuSkipDetailRequest(cnf_studentmenuskipdetailEntity objcnf_studentmenuskipdetail)
        {
            Objcnf_studentmenuskipdetail = objcnf_studentmenuskipdetail;
        }
    }
}
