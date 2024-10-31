using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_FamillyRequest : IUseCaseRequest<Reg_FamillyResponse>
    {
        public reg_famillyEntity Objreg_familly { get; }

        public Reg_FamillyRequest(reg_famillyEntity objreg_familly)
        {
            Objreg_familly = objreg_familly;
        }
    }
}
