using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandidateTypeMapUseCase : IUseCaseRequestHandler<Gen_BatchCandidateTypeMapRequest, Gen_BatchCandidateTypeMapResponse>
    {
        Task<bool> Save(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

        Task<bool> Update(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

        Task<bool> Delete(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

        Task<bool> GetSingle(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

        Task<bool> GetAll(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

        Task<bool> GetAllPaged(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

        Task<bool> GetListView(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

        Task<bool> GetDataForDropDown(Gen_BatchCandidateTypeMapRequest message, IDDLRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);

    }
}
