using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_LanguagesUseCase : IUseCaseRequestHandler<Gen_LanguagesRequest, Gen_LanguagesResponse>
    {
        Task<bool> Save(Gen_LanguagesRequest message, ICRUDRequestHandler<Gen_LanguagesResponse> outputPort);

        Task<bool> Update(Gen_LanguagesRequest message, ICRUDRequestHandler<Gen_LanguagesResponse> outputPort);

        Task<bool> Delete(Gen_LanguagesRequest message, ICRUDRequestHandler<Gen_LanguagesResponse> outputPort);


        Task<bool> GetSingle(Gen_LanguagesRequest message, ICRUDRequestHandler<Gen_LanguagesResponse> outputPort);

        Task<bool> GetAll(Gen_LanguagesRequest message, ICRUDRequestHandler<Gen_LanguagesResponse> outputPort);


        Task<bool> GetAllPaged(Gen_LanguagesRequest message, ICRUDRequestHandler<Gen_LanguagesResponse> outputPort);

        Task<bool> GetListView(Gen_LanguagesRequest message, ICRUDRequestHandler<Gen_LanguagesResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_LanguagesRequest message, IDDLRequestHandler<Gen_LanguagesResponse> outputPort);
    
    }
}
