using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_GenderUseCase : IUseCaseRequestHandler<Gen_GenderRequest, Gen_GenderResponse>
    {
        Task<bool> Save(Gen_GenderRequest message, ICRUDRequestHandler<Gen_GenderResponse> outputPort);

        Task<bool> Update(Gen_GenderRequest message, ICRUDRequestHandler<Gen_GenderResponse> outputPort);

        Task<bool> Delete(Gen_GenderRequest message, ICRUDRequestHandler<Gen_GenderResponse> outputPort);


        Task<bool> GetSingle(Gen_GenderRequest message, ICRUDRequestHandler<Gen_GenderResponse> outputPort);

        Task<bool> GetAll(Gen_GenderRequest message, ICRUDRequestHandler<Gen_GenderResponse> outputPort);


        Task<bool> GetAllPaged(Gen_GenderRequest message, ICRUDRequestHandler<Gen_GenderResponse> outputPort);

        Task<bool> GetListView(Gen_GenderRequest message, ICRUDRequestHandler<Gen_GenderResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_GenderRequest message, IDDLRequestHandler<Gen_GenderResponse> outputPort);
    
    }
}
