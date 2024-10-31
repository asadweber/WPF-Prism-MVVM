using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_EContactListUseCase : IUseCaseRequestHandler<Gen_EContactListRequest, Gen_EContactListResponse>
    {
        Task<bool> Save(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort);

        Task<bool> Update(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort);

        Task<bool> Delete(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort);


        Task<bool> GetSingle(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort);

        Task<bool> GetAll(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort);


        Task<bool> GetAllPaged(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort);

        Task<bool> GetListView(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort);
        
        
            
    }
}
