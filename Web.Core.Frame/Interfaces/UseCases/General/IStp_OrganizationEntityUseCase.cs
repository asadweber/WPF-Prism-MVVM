using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IStp_OrganizationEntityUseCase : IUseCaseRequestHandler<Stp_OrganizationEntityRequest, Stp_OrganizationEntityResponse>
    {
        Task<bool> Save(Stp_OrganizationEntityRequest message, ICRUDRequestHandler<Stp_OrganizationEntityResponse> outputPort);

        Task<bool> Update(Stp_OrganizationEntityRequest message, ICRUDRequestHandler<Stp_OrganizationEntityResponse> outputPort);

        Task<bool> Delete(Stp_OrganizationEntityRequest message, ICRUDRequestHandler<Stp_OrganizationEntityResponse> outputPort);


        Task<bool> GetSingle(Stp_OrganizationEntityRequest message, ICRUDRequestHandler<Stp_OrganizationEntityResponse> outputPort);

        Task<bool> GetAll(Stp_OrganizationEntityRequest message, ICRUDRequestHandler<Stp_OrganizationEntityResponse> outputPort);


        Task<bool> GetAllPaged(Stp_OrganizationEntityRequest message, ICRUDRequestHandler<Stp_OrganizationEntityResponse> outputPort);

        Task<bool> GetListView(Stp_OrganizationEntityRequest message, ICRUDRequestHandler<Stp_OrganizationEntityResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Stp_OrganizationEntityRequest message, IDDLRequestHandler<Stp_OrganizationEntityResponse> outputPort);
    
    }
}
