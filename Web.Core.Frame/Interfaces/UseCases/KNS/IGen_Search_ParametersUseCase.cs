using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_Search_ParametersUseCase : IUseCaseRequestHandler<Gen_Search_ParametersRequest, Gen_Search_ParametersResponse>
    {
        Task<bool> Save(Gen_Search_ParametersRequest message, ICRUDRequestHandler<Gen_Search_ParametersResponse> outputPort);

        Task<bool> Update(Gen_Search_ParametersRequest message, ICRUDRequestHandler<Gen_Search_ParametersResponse> outputPort);

        Task<bool> Delete(Gen_Search_ParametersRequest message, ICRUDRequestHandler<Gen_Search_ParametersResponse> outputPort);


        Task<bool> GetSingle(Gen_Search_ParametersRequest message, ICRUDRequestHandler<Gen_Search_ParametersResponse> outputPort);

        Task<bool> GetAll(Gen_Search_ParametersRequest message, ICRUDRequestHandler<Gen_Search_ParametersResponse> outputPort);


        Task<bool> GetAllPaged(Gen_Search_ParametersRequest message, ICRUDRequestHandler<Gen_Search_ParametersResponse> outputPort);

        Task<bool> GetListView(Gen_Search_ParametersRequest message, ICRUDRequestHandler<Gen_Search_ParametersResponse> outputPort);
        
        
            
    }
}
