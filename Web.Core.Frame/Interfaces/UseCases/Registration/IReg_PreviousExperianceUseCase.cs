using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_PreviousExperianceUseCase : IUseCaseRequestHandler<Reg_PreviousExperianceRequest, Reg_PreviousExperianceResponse>
    {
        Task<bool> Save(Reg_PreviousExperianceRequest message, ICRUDRequestHandler<Reg_PreviousExperianceResponse> outputPort);

        Task<bool> Update(Reg_PreviousExperianceRequest message, ICRUDRequestHandler<Reg_PreviousExperianceResponse> outputPort);

        Task<bool> Delete(Reg_PreviousExperianceRequest message, ICRUDRequestHandler<Reg_PreviousExperianceResponse> outputPort);


        Task<bool> GetSingle(Reg_PreviousExperianceRequest message, ICRUDRequestHandler<Reg_PreviousExperianceResponse> outputPort);

        Task<bool> GetAll(Reg_PreviousExperianceRequest message, ICRUDRequestHandler<Reg_PreviousExperianceResponse> outputPort);


        Task<bool> GetAllPaged(Reg_PreviousExperianceRequest message, ICRUDRequestHandler<Reg_PreviousExperianceResponse> outputPort);

        Task<bool> GetListView(Reg_PreviousExperianceRequest message, ICRUDRequestHandler<Reg_PreviousExperianceResponse> outputPort);



    }
}
