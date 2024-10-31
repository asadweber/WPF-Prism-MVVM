using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchUseCase : IUseCaseRequestHandler<Gen_BatchRequest, Gen_BatchResponse>
    {
        Task<bool> GetActiveBatchDropDown(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort);
        
        Task<bool> GetActiveBatchDropDownForReview(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort);

        Task<bool> GetAllBatchDropDown(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort);

        Task<bool> GetBatchDropDownById(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);

        Task<bool> GetMilitaryTypeWiseBatchForDropDown(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort);
    }
}
