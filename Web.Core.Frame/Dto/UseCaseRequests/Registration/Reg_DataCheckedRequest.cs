using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_DataCheckedRequest : IUseCaseRequest<Reg_DataCheckedResponse>
    {
        public reg_datacheckedEntity Objreg_datachecked { get; }

        public Reg_DataCheckedRequest(reg_datacheckedEntity objreg_datachecked)
        {
            Objreg_datachecked = objreg_datachecked;
        }
    }
}
