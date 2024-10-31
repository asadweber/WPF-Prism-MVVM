using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CompaniesUseCase : IUseCaseRequestHandler<Gen_CompaniesRequest, Gen_CompaniesResponse>
    {
        Task<bool> Save(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);

        Task<bool> Update(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);

        Task<bool> Delete(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);


        Task<bool> GetSingle(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);

        Task<bool> GetAll(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);

        Task<bool> GetListView(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);

        Task<bool> GetDataForDropDown(Gen_CompaniesRequest message, IDDLRequestHandler<Gen_CompaniesResponse> outputPort);

    }
}
