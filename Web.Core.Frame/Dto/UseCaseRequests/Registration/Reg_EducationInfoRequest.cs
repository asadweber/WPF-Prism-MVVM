using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_EducationInfoRequest : IUseCaseRequest<Reg_EducationInfoResponse>
    {
        public reg_educationinfoEntity Objreg_educationinfo { get; }

        public Reg_EducationInfoRequest(reg_educationinfoEntity objreg_educationinfo)
        {
            Objreg_educationinfo = objreg_educationinfo;
        }
    }
}
