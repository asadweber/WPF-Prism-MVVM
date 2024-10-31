using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_PunishmentRequest : IUseCaseRequest<Reg_PunishmentResponse>
    {
        public reg_punishmentEntity Objreg_punishment { get; }

        public Reg_PunishmentRequest(reg_punishmentEntity objreg_punishment)
        {
            Objreg_punishment = objreg_punishment;
        }
    }
}
