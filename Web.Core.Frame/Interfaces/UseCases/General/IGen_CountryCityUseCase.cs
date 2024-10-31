using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CountryCityUseCase : IUseCaseRequestHandler<Gen_CountryCityRequest, Gen_CountryCityResponse>
    {
        Task<bool> Save(Gen_CountryCityRequest message, ICRUDRequestHandler<Gen_CountryCityResponse> outputPort);

        Task<bool> Update(Gen_CountryCityRequest message, ICRUDRequestHandler<Gen_CountryCityResponse> outputPort);

        Task<bool> Delete(Gen_CountryCityRequest message, ICRUDRequestHandler<Gen_CountryCityResponse> outputPort);


        Task<bool> GetSingle(Gen_CountryCityRequest message, ICRUDRequestHandler<Gen_CountryCityResponse> outputPort);

        Task<bool> GetAll(Gen_CountryCityRequest message, ICRUDRequestHandler<Gen_CountryCityResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CountryCityRequest message, ICRUDRequestHandler<Gen_CountryCityResponse> outputPort);

        Task<bool> GetListView(Gen_CountryCityRequest message, ICRUDRequestHandler<Gen_CountryCityResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CountryCityRequest message, IDDLRequestHandler<Gen_CountryCityResponse> outputPort);
    
    }
}
