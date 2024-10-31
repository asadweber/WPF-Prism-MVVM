using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_BasicInfoRequest : IUseCaseRequest<Reg_BasicInfoResponse>
    {
        public reg_basicinfoEntity Objreg_basicinfo { get; }

        public Reg_BasicInfoRequest(reg_basicinfoEntity objreg_basicinfo)
        {
            Objreg_basicinfo = objreg_basicinfo;
        }
    }
}
