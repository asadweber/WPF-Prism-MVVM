using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchUseCase : IUseCaseRequestHandler<Gen_BatchRequest, Gen_BatchResponse>
    {
        Task<bool> Save(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);

        Task<bool> Update(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);

        Task<bool> Delete(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);


        Task<bool> GetSingle(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);

        Task<bool> GetAll(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);


        Task<bool> GetAllPaged(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);

        Task<bool> GetListView(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort);


        Task<bool> GetDataForDropDown(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort);

    }
}
