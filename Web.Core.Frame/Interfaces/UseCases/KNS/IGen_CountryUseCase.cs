using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CountryUseCase : IUseCaseRequestHandler<Gen_CountryRequest, Gen_CountryResponse>
    {
        Task<bool> Save(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);

        Task<bool> Update(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);

        Task<bool> Delete(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);


        Task<bool> GetSingle(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);

        Task<bool> GetAll(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);

        Task<bool> GetListView(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
    
    }
}
