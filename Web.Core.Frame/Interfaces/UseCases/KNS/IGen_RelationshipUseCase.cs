using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_RelationshipUseCase : IUseCaseRequestHandler<Gen_RelationshipRequest, Gen_RelationshipResponse>
    {
        Task<bool> Save(Gen_RelationshipRequest message, ICRUDRequestHandler<Gen_RelationshipResponse> outputPort);

        Task<bool> Update(Gen_RelationshipRequest message, ICRUDRequestHandler<Gen_RelationshipResponse> outputPort);

        Task<bool> Delete(Gen_RelationshipRequest message, ICRUDRequestHandler<Gen_RelationshipResponse> outputPort);


        Task<bool> GetSingle(Gen_RelationshipRequest message, ICRUDRequestHandler<Gen_RelationshipResponse> outputPort);

        Task<bool> GetAll(Gen_RelationshipRequest message, ICRUDRequestHandler<Gen_RelationshipResponse> outputPort);


        Task<bool> GetAllPaged(Gen_RelationshipRequest message, ICRUDRequestHandler<Gen_RelationshipResponse> outputPort);

        Task<bool> GetListView(Gen_RelationshipRequest message, ICRUDRequestHandler<Gen_RelationshipResponse> outputPort);

        Task<bool> GetDataForDropDown(Gen_RelationshipRequest message, IDDLRequestHandler<Gen_RelationshipResponse> outputPort);

    }
}
