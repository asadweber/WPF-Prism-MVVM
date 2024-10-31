using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_FileRequiredRequest : IUseCaseRequest<Cnf_FileRequiredResponse>
    {
        public cnf_filerequiredEntity Objcnf_filerequired { get; }

        public Cnf_FileRequiredRequest(cnf_filerequiredEntity objcnf_filerequired)
        {
            Objcnf_filerequired = objcnf_filerequired;
        }
    }
}
