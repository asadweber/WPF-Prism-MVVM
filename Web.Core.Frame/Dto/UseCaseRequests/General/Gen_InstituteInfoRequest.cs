using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_InstituteInfoRequest : IUseCaseRequest<Gen_InstituteInfoResponse>
    {
        public gen_instituteinfoEntity Objgen_instituteinfo { get; }
        
        public Gen_InstituteInfoRequest(gen_instituteinfoEntity objgen_instituteinfo)
        {
            Objgen_instituteinfo = objgen_instituteinfo;
        }
    }
}
