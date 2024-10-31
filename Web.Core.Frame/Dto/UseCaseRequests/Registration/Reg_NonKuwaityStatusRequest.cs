using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_NonKuwaityStatusRequest : IUseCaseRequest<Reg_NonKuwaityStatusResponse>
    {
        public reg_nonkuwaitystatusEntity Objreg_nonkuwaitystatus { get; }

        public Reg_NonKuwaityStatusRequest(reg_nonkuwaitystatusEntity objreg_nonkuwaitystatus)
        {
            Objreg_nonkuwaitystatus = objreg_nonkuwaitystatus;
        }
    }
}
