using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_EducationInfoUseCase : IUseCaseRequestHandler<Reg_EducationInfoRequest, Reg_EducationInfoResponse>
    {
        Task<bool> Save(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);

        Task<bool> Update(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);

        Task<bool> Delete(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);


        Task<bool> GetSingle(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);

        Task<bool> GetAll(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);


        Task<bool> GetAllPaged(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);

        Task<bool> GetListView(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort);



    }
}
