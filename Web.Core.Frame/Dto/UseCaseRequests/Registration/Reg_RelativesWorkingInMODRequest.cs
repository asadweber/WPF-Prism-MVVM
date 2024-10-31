using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_RelativesWorkingInMODRequest : IUseCaseRequest<Reg_RelativesWorkingInMODResponse>
    {
        public reg_relativesworkinginmodEntity Objreg_relativesworkinginmod { get; }

        public Reg_RelativesWorkingInMODRequest(reg_relativesworkinginmodEntity objreg_relativesworkinginmod)
        {
            Objreg_relativesworkinginmod = objreg_relativesworkinginmod;
        }
    }
}
