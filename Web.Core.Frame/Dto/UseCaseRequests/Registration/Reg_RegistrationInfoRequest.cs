using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_RegistrationInfoRequest : IUseCaseRequest<Reg_RegistrationInfoResponse>
    {
        public reg_registrationinfoEntity Objreg_registrationinfo { get; }
        public List<reg_registrationinfoEntity> Objreg_registrationinfoList { get; }

        public Reg_RegistrationInfoRequest(reg_registrationinfoEntity objreg_registrationinfo)
        {
            Objreg_registrationinfo = objreg_registrationinfo;
        }

        public Reg_RegistrationInfoRequest(List<reg_registrationinfoEntity> objreg_registrationinfoList)
        {
            objreg_registrationinfoList = objreg_registrationinfoList;
        }
    }
}
