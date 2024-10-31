using DocumentFormat.OpenXml.Drawing.Charts;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
   public partial interface IReg_FamillyUseCase : IUseCaseRequestHandler<Reg_FamillyRequest, Reg_FamillyResponse>
   {
        Task<bool> SaveFather(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> ApplicantReviewSaveFatherInfo(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> SaveMother(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> ApplicantReviewSaveMotherInfo(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetAllFatheWifeSpouseByPage(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetAllMotherHusbandSpouseByPage(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> CheckHasSpouce(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> DeleteByFamilityId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetBrotherListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> SaveUpdateWithSpouse(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> ApplicantReviewSaveUpdateWithSpouse(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetSisterListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);

        Task<bool> GetPaternalUncleListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetPaternalAuntyListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetMaternalUncleListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetMaternalAuntyListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);
        Task<bool> GetProfileSpouseListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);

        Task<bool> GetSingleByIdWithDocument(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);

    }
}
