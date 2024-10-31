using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CivilWorkPlacesUseCase : IUseCaseRequestHandler<Gen_CivilWorkPlacesRequest, Gen_CivilWorkPlacesResponse>
    {
        Task<bool> Save(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);

        Task<bool> Update(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);

        Task<bool> Delete(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);


        Task<bool> GetSingle(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);

        Task<bool> GetAll(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);

        Task<bool> GetListView(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CivilWorkPlacesRequest message, IDDLRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);
    
    }
}
