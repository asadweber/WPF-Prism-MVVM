using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_FamillyUseCase : IUseCaseRequestHandler<Reg_FamillyRequest, Reg_FamillyResponse>
    {
        Task<bool> Save(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);

        Task<bool> Update(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);

        Task<bool> Delete(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);


        Task<bool> GetSingle(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);

        Task<bool> GetAll(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);


        Task<bool> GetAllPaged(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);

        Task<bool> GetListView(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort);


        Task<bool> GetDataForDropDown(Reg_FamillyRequest message, IDDLRequestHandler<Reg_FamillyResponse> outputPort);

    }
}
