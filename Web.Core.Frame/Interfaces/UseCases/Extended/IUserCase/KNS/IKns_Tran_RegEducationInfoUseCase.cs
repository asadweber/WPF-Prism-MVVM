using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegEducationInfoUseCase 
    {
        //Task<bool> AddEducations(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);


        Task<bool> GetEducations(Kns_Tran_RegEducationInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegEducationInfoResponse> outputPort);
        
        
            
    }
}
