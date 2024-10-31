using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_EmergencyContactInfoRequest : IUseCaseRequest<Reg_EmergencyContactInfoResponse>
    {
        public reg_emergencycontactinfoEntity Objreg_emergencycontactinfo { get; }

        public Reg_EmergencyContactInfoRequest(reg_emergencycontactinfoEntity objreg_emergencycontactinfo)
        {
            Objreg_emergencycontactinfo = objreg_emergencycontactinfo;
        }
    }
}
