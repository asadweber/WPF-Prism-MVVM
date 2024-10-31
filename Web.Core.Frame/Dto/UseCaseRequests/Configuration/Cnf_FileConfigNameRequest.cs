using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Cnf_FileConfigNameRequest : IUseCaseRequest<Cnf_FileConfigNameResponse>
    {
        public cnf_fileconfignameEntity Objcnf_fileconfigname { get; }
        
        public Cnf_FileConfigNameRequest(cnf_fileconfignameEntity objcnf_fileconfigname)
        {
            Objcnf_fileconfigname = objcnf_fileconfigname;
        }
    }
}
