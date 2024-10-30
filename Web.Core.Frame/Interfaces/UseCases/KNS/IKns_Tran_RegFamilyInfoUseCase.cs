using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegFamilyInfoUseCase : IUseCaseRequestHandler<Kns_Tran_RegFamilyInfoRequest, Kns_Tran_RegFamilyInfoResponse>
    {
        Task<bool> Save(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);

        Task<bool> Update(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);

        Task<bool> Delete(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);
        
        
            
    }
}
