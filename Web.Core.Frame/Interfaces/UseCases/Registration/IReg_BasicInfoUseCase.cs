using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_BasicInfoUseCase : IUseCaseRequestHandler<Reg_BasicInfoRequest, Reg_BasicInfoResponse>
    {
        Task<bool> Save(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);

        Task<bool> Update(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);

        Task<bool> Delete(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);


        Task<bool> GetSingle(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);

        Task<bool> GetAll(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);


        Task<bool> GetAllPaged(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);

        Task<bool> GetListView(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort);


        Task<bool> GetDataForDropDown(Reg_BasicInfoRequest message, IDDLRequestHandler<Reg_BasicInfoResponse> outputPort);

    }
}
