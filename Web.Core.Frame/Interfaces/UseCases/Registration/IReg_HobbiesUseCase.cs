using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_HobbiesUseCase : IUseCaseRequestHandler<Reg_HobbiesRequest, Reg_HobbiesResponse>
    {
        Task<bool> Save(Reg_HobbiesRequest message, ICRUDRequestHandler<Reg_HobbiesResponse> outputPort);

        Task<bool> Update(Reg_HobbiesRequest message, ICRUDRequestHandler<Reg_HobbiesResponse> outputPort);

        Task<bool> Delete(Reg_HobbiesRequest message, ICRUDRequestHandler<Reg_HobbiesResponse> outputPort);


        Task<bool> GetSingle(Reg_HobbiesRequest message, ICRUDRequestHandler<Reg_HobbiesResponse> outputPort);

        Task<bool> GetAll(Reg_HobbiesRequest message, ICRUDRequestHandler<Reg_HobbiesResponse> outputPort);


        Task<bool> GetAllPaged(Reg_HobbiesRequest message, ICRUDRequestHandler<Reg_HobbiesResponse> outputPort);

        Task<bool> GetListView(Reg_HobbiesRequest message, ICRUDRequestHandler<Reg_HobbiesResponse> outputPort);



    }
}
