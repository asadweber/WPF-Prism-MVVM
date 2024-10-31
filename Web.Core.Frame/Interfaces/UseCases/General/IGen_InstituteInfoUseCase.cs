using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_InstituteInfoUseCase : IUseCaseRequestHandler<Gen_InstituteInfoRequest, Gen_InstituteInfoResponse>
    {
        Task<bool> Save(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);

        Task<bool> Update(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);

        Task<bool> Delete(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);


        Task<bool> GetSingle(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);

        Task<bool> GetAll(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);


        Task<bool> GetAllPaged(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);

        Task<bool> GetListView(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_InstituteInfoRequest message, IDDLRequestHandler<Gen_InstituteInfoResponse> outputPort);
    
    }
}
