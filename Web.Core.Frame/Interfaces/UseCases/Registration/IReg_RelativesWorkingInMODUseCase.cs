using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_RelativesWorkingInMODUseCase : IUseCaseRequestHandler<Reg_RelativesWorkingInMODRequest, Reg_RelativesWorkingInMODResponse>
    {
        Task<bool> Save(Reg_RelativesWorkingInMODRequest message, ICRUDRequestHandler<Reg_RelativesWorkingInMODResponse> outputPort);

        Task<bool> Update(Reg_RelativesWorkingInMODRequest message, ICRUDRequestHandler<Reg_RelativesWorkingInMODResponse> outputPort);

        Task<bool> Delete(Reg_RelativesWorkingInMODRequest message, ICRUDRequestHandler<Reg_RelativesWorkingInMODResponse> outputPort);


        Task<bool> GetSingle(Reg_RelativesWorkingInMODRequest message, ICRUDRequestHandler<Reg_RelativesWorkingInMODResponse> outputPort);

        Task<bool> GetAll(Reg_RelativesWorkingInMODRequest message, ICRUDRequestHandler<Reg_RelativesWorkingInMODResponse> outputPort);


        Task<bool> GetAllPaged(Reg_RelativesWorkingInMODRequest message, ICRUDRequestHandler<Reg_RelativesWorkingInMODResponse> outputPort);

        Task<bool> GetListView(Reg_RelativesWorkingInMODRequest message, ICRUDRequestHandler<Reg_RelativesWorkingInMODResponse> outputPort);



    }
}
