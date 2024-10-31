using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ProfessionUseCase : IUseCaseRequestHandler<Gen_ProfessionRequest, Gen_ProfessionResponse>
    {
        Task<bool> Save(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);

        Task<bool> Update(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);

        Task<bool> Delete(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);


        Task<bool> GetSingle(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);

        Task<bool> GetAll(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);

        Task<bool> GetListView(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_ProfessionRequest message, IDDLRequestHandler<Gen_ProfessionResponse> outputPort);
    
    }
}
