using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_MaritalStatusUseCase : IUseCaseRequestHandler<Gen_MaritalStatusRequest, Gen_MaritalStatusResponse>
    {
        Task<bool> Save(Gen_MaritalStatusRequest message, ICRUDRequestHandler<Gen_MaritalStatusResponse> outputPort);

        Task<bool> Update(Gen_MaritalStatusRequest message, ICRUDRequestHandler<Gen_MaritalStatusResponse> outputPort);

        Task<bool> Delete(Gen_MaritalStatusRequest message, ICRUDRequestHandler<Gen_MaritalStatusResponse> outputPort);


        Task<bool> GetSingle(Gen_MaritalStatusRequest message, ICRUDRequestHandler<Gen_MaritalStatusResponse> outputPort);

        Task<bool> GetAll(Gen_MaritalStatusRequest message, ICRUDRequestHandler<Gen_MaritalStatusResponse> outputPort);


        Task<bool> GetAllPaged(Gen_MaritalStatusRequest message, ICRUDRequestHandler<Gen_MaritalStatusResponse> outputPort);

        Task<bool> GetListView(Gen_MaritalStatusRequest message, ICRUDRequestHandler<Gen_MaritalStatusResponse> outputPort);

        Task<bool> GetDataForDropDown(Gen_MaritalStatusRequest message, IDDLRequestHandler<Gen_MaritalStatusResponse> outputPort);

    }
}
