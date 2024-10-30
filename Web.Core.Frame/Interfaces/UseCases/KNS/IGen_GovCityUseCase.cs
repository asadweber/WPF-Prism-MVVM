using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_GovCityUseCase : IUseCaseRequestHandler<Gen_GovCityRequest, Gen_GovCityResponse>
    {
        Task<bool> Save(Gen_GovCityRequest message, ICRUDRequestHandler<Gen_GovCityResponse> outputPort);

        Task<bool> Update(Gen_GovCityRequest message, ICRUDRequestHandler<Gen_GovCityResponse> outputPort);

        Task<bool> Delete(Gen_GovCityRequest message, ICRUDRequestHandler<Gen_GovCityResponse> outputPort);


        Task<bool> GetSingle(Gen_GovCityRequest message, ICRUDRequestHandler<Gen_GovCityResponse> outputPort);

        Task<bool> GetAll(Gen_GovCityRequest message, ICRUDRequestHandler<Gen_GovCityResponse> outputPort);


        Task<bool> GetAllPaged(Gen_GovCityRequest message, ICRUDRequestHandler<Gen_GovCityResponse> outputPort);

        Task<bool> GetListView(Gen_GovCityRequest message, ICRUDRequestHandler<Gen_GovCityResponse> outputPort);

        Task<bool> GetDataForDropDown(Gen_GovCityRequest message, IDDLRequestHandler<Gen_GovCityResponse> outputPort);

    }
}
