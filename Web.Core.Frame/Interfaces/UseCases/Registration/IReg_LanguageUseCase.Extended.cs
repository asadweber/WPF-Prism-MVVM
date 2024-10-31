using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
   public partial interface IReg_LanguageUseCase : IUseCaseRequestHandler<Reg_LanguageRequest, Reg_LanguageResponse>
   {

   }
}
