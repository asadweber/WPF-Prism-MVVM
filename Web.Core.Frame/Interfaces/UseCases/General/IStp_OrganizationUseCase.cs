using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IStp_OrganizationUseCase : IUseCaseRequestHandler<Stp_OrganizationRequest, Stp_OrganizationResponse>
    {
        Task<bool> Save(Stp_OrganizationRequest message, ICRUDRequestHandler<Stp_OrganizationResponse> outputPort);

        Task<bool> Update(Stp_OrganizationRequest message, ICRUDRequestHandler<Stp_OrganizationResponse> outputPort);

        Task<bool> Delete(Stp_OrganizationRequest message, ICRUDRequestHandler<Stp_OrganizationResponse> outputPort);


        Task<bool> GetSingle(Stp_OrganizationRequest message, ICRUDRequestHandler<Stp_OrganizationResponse> outputPort);

        Task<bool> GetAll(Stp_OrganizationRequest message, ICRUDRequestHandler<Stp_OrganizationResponse> outputPort);


        Task<bool> GetAllPaged(Stp_OrganizationRequest message, ICRUDRequestHandler<Stp_OrganizationResponse> outputPort);

        Task<bool> GetListView(Stp_OrganizationRequest message, ICRUDRequestHandler<Stp_OrganizationResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Stp_OrganizationRequest message, IDDLRequestHandler<Stp_OrganizationResponse> outputPort);
    
    }
}
