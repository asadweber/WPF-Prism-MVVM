using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegImergencyContactInfoUseCase : IUseCaseRequestHandler<Kns_Tran_RegImergencyContactInfoRequest, Kns_Tran_RegImergencyContactInfoResponse>
    {
        Task<bool> Save(Kns_Tran_RegImergencyContactInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegImergencyContactInfoResponse> outputPort);

        Task<bool> Update(Kns_Tran_RegImergencyContactInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegImergencyContactInfoResponse> outputPort);

        Task<bool> Delete(Kns_Tran_RegImergencyContactInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegImergencyContactInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_RegImergencyContactInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegImergencyContactInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_RegImergencyContactInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegImergencyContactInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_RegImergencyContactInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegImergencyContactInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_RegImergencyContactInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegImergencyContactInfoResponse> outputPort);
        
        
            
    }
}
