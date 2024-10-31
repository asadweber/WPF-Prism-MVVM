using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_PreviousExperianceRequest : IUseCaseRequest<Reg_PreviousExperianceResponse>
    {
        public reg_previousexperianceEntity Objreg_previousexperiance { get; }

        public Reg_PreviousExperianceRequest(reg_previousexperianceEntity objreg_previousexperiance)
        {
            Objreg_previousexperiance = objreg_previousexperiance;
        }
    }
}
