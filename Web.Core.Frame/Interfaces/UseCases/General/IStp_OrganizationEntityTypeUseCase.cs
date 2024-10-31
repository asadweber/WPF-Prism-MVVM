using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IStp_OrganizationEntityTypeUseCase : IUseCaseRequestHandler<Stp_OrganizationEntityTypeRequest, Stp_OrganizationEntityTypeResponse>
    {
        Task<bool> Save(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);

        Task<bool> Update(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);

        Task<bool> Delete(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);


        Task<bool> GetSingle(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);

        Task<bool> GetAll(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);


        Task<bool> GetAllPaged(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);

        Task<bool> GetListView(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Stp_OrganizationEntityTypeRequest message, IDDLRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort);
    
    }
}
