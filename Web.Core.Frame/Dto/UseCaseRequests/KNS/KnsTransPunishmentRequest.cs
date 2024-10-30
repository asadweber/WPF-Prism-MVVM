using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class KnsTransPunishmentRequest : IUseCaseRequest<KnsTransPunishmentResponse>
    {
        public knstranspunishmentEntity Objknstranspunishment { get; }
        
        public KnsTransPunishmentRequest(knstranspunishmentEntity objknstranspunishment)
        {
            Objknstranspunishment = objknstranspunishment;
        }
    }
}
