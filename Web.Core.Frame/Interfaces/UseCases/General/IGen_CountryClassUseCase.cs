using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CountryClassUseCase : IUseCaseRequestHandler<Gen_CountryClassRequest, Gen_CountryClassResponse>
    {
        Task<bool> Save(Gen_CountryClassRequest message, ICRUDRequestHandler<Gen_CountryClassResponse> outputPort);

        Task<bool> Update(Gen_CountryClassRequest message, ICRUDRequestHandler<Gen_CountryClassResponse> outputPort);

        Task<bool> Delete(Gen_CountryClassRequest message, ICRUDRequestHandler<Gen_CountryClassResponse> outputPort);


        Task<bool> GetSingle(Gen_CountryClassRequest message, ICRUDRequestHandler<Gen_CountryClassResponse> outputPort);

        Task<bool> GetAll(Gen_CountryClassRequest message, ICRUDRequestHandler<Gen_CountryClassResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CountryClassRequest message, ICRUDRequestHandler<Gen_CountryClassResponse> outputPort);

        Task<bool> GetListView(Gen_CountryClassRequest message, ICRUDRequestHandler<Gen_CountryClassResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CountryClassRequest message, IDDLRequestHandler<Gen_CountryClassResponse> outputPort);
    
    }
}
