using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
   public partial interface IReg_BasicInfoUseCase : IUseCaseRequestHandler<Reg_BasicInfoRequest, Reg_BasicInfoResponse>
   {
        Task<bool> GetAllRegBasicInfoByMultipleBasicID(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);
        Task<bool> DeleteApplicantbyBasicInfoID(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);
        Task<bool> UpdateApplicantContactInfo(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);
    }
}
