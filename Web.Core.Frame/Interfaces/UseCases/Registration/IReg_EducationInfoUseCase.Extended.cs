using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
   public partial interface IReg_EducationInfoUseCase : IUseCaseRequestHandler<Reg_EducationInfoRequest, Reg_EducationInfoResponse>
   {
        Task<bool> GetListViewByBasicId(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);
        Task<bool> GetSingleById(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);

        Task<bool> SaveOrUpdate(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);
        Task<bool> ApllicantReviewEducationInfoSaveorUpdate(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);
        Task<bool> DeleteWithAttachment(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);


    }
}
