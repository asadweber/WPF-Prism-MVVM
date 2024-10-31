using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_HobbiesRequest : IUseCaseRequest<Reg_HobbiesResponse>
    {
        public reg_hobbiesEntity Objreg_hobbies { get; }

        public Reg_HobbiesRequest(reg_hobbiesEntity objreg_hobbies)
        {
            Objreg_hobbies = objreg_hobbies;
        }
    }
}
