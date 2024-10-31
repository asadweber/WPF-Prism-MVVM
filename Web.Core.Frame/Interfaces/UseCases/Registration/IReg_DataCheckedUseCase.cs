using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_DataCheckedUseCase : IUseCaseRequestHandler<Reg_DataCheckedRequest, Reg_DataCheckedResponse>
    {
        Task<bool> Save(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);

        Task<bool> Update(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);

        Task<bool> Delete(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);


        Task<bool> GetSingle(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);

        Task<bool> GetAll(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);


        Task<bool> GetAllPaged(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);

        Task<bool> GetListView(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);


        Task<bool> GetDataForDropDown(Reg_DataCheckedRequest message, IDDLRequestHandler<Reg_DataCheckedResponse> outputPort);

    }
}
