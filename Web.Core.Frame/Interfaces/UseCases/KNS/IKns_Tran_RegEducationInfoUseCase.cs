using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegEducationInfoUseCase : IUseCaseRequestHandler<Kns_Tran_RegEducationInfoRequest, Kns_Tran_RegEducationInfoResponse>
    {
        Task<bool> Save(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);

        Task<bool> Update(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);

        Task<bool> Delete(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);
        
        
            
    }
}
