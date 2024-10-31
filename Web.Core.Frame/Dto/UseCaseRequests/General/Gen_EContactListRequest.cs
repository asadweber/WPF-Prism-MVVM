using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_EContactListRequest : IUseCaseRequest<Gen_EContactListResponse>
    {
        public gen_econtactlistEntity Objgen_econtactlist { get; }
        
        public Gen_EContactListRequest(gen_econtactlistEntity objgen_econtactlist)
        {
            Objgen_econtactlist = objgen_econtactlist;
        }
    }
}
