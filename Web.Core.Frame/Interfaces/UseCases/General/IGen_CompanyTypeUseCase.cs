using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CompanyTypeUseCase : IUseCaseRequestHandler<Gen_CompanyTypeRequest, Gen_CompanyTypeResponse>
    {
        Task<bool> Save(Gen_CompanyTypeRequest message, ICRUDRequestHandler<Gen_CompanyTypeResponse> outputPort);

        Task<bool> Update(Gen_CompanyTypeRequest message, ICRUDRequestHandler<Gen_CompanyTypeResponse> outputPort);

        Task<bool> Delete(Gen_CompanyTypeRequest message, ICRUDRequestHandler<Gen_CompanyTypeResponse> outputPort);


        Task<bool> GetSingle(Gen_CompanyTypeRequest message, ICRUDRequestHandler<Gen_CompanyTypeResponse> outputPort);

        Task<bool> GetAll(Gen_CompanyTypeRequest message, ICRUDRequestHandler<Gen_CompanyTypeResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CompanyTypeRequest message, ICRUDRequestHandler<Gen_CompanyTypeResponse> outputPort);

        Task<bool> GetListView(Gen_CompanyTypeRequest message, ICRUDRequestHandler<Gen_CompanyTypeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CompanyTypeRequest message, IDDLRequestHandler<Gen_CompanyTypeResponse> outputPort);
    
    }
}
