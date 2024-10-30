using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_UsefulLinkUseCase : IUseCaseRequestHandler<Gen_UsefulLinkRequest, Gen_UsefulLinkResponse>
    {
        Task<bool> Save(Gen_UsefulLinkRequest message, ICRUDRequestHandler<Gen_UsefulLinkResponse> outputPort);

        Task<bool> Update(Gen_UsefulLinkRequest message, ICRUDRequestHandler<Gen_UsefulLinkResponse> outputPort);

        Task<bool> Delete(Gen_UsefulLinkRequest message, ICRUDRequestHandler<Gen_UsefulLinkResponse> outputPort);


        Task<bool> GetSingle(Gen_UsefulLinkRequest message, ICRUDRequestHandler<Gen_UsefulLinkResponse> outputPort);

        Task<bool> GetAll(Gen_UsefulLinkRequest message, ICRUDRequestHandler<Gen_UsefulLinkResponse> outputPort);


        Task<bool> GetAllPaged(Gen_UsefulLinkRequest message, ICRUDRequestHandler<Gen_UsefulLinkResponse> outputPort);

        Task<bool> GetListView(Gen_UsefulLinkRequest message, ICRUDRequestHandler<Gen_UsefulLinkResponse> outputPort);
        
        
            
    }
}
