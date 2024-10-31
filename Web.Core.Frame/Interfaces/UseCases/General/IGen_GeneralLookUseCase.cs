using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_GeneralLookUseCase : IUseCaseRequestHandler<Gen_GeneralLookRequest, Gen_GeneralLookResponse>
    {
        Task<bool> Save(Gen_GeneralLookRequest message, ICRUDRequestHandler<Gen_GeneralLookResponse> outputPort);

        Task<bool> Update(Gen_GeneralLookRequest message, ICRUDRequestHandler<Gen_GeneralLookResponse> outputPort);

        Task<bool> Delete(Gen_GeneralLookRequest message, ICRUDRequestHandler<Gen_GeneralLookResponse> outputPort);


        Task<bool> GetSingle(Gen_GeneralLookRequest message, ICRUDRequestHandler<Gen_GeneralLookResponse> outputPort);

        Task<bool> GetAll(Gen_GeneralLookRequest message, ICRUDRequestHandler<Gen_GeneralLookResponse> outputPort);


        Task<bool> GetAllPaged(Gen_GeneralLookRequest message, ICRUDRequestHandler<Gen_GeneralLookResponse> outputPort);

        Task<bool> GetListView(Gen_GeneralLookRequest message, ICRUDRequestHandler<Gen_GeneralLookResponse> outputPort);
        
        
            
    }
}
