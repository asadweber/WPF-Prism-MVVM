using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ReligionUseCase : IUseCaseRequestHandler<Gen_ReligionRequest, Gen_ReligionResponse>
    {
        Task<bool> Save(Gen_ReligionRequest message, ICRUDRequestHandler<Gen_ReligionResponse> outputPort);

        Task<bool> Update(Gen_ReligionRequest message, ICRUDRequestHandler<Gen_ReligionResponse> outputPort);

        Task<bool> Delete(Gen_ReligionRequest message, ICRUDRequestHandler<Gen_ReligionResponse> outputPort);


        Task<bool> GetSingle(Gen_ReligionRequest message, ICRUDRequestHandler<Gen_ReligionResponse> outputPort);

        Task<bool> GetAll(Gen_ReligionRequest message, ICRUDRequestHandler<Gen_ReligionResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ReligionRequest message, ICRUDRequestHandler<Gen_ReligionResponse> outputPort);

        Task<bool> GetListView(Gen_ReligionRequest message, ICRUDRequestHandler<Gen_ReligionResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_ReligionRequest message, IDDLRequestHandler<Gen_ReligionResponse> outputPort);
    
    }
}
