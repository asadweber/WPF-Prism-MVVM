using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegFamilyInfoUseCase 
    {
     
        Task<bool> GetFamilyByBasicId(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);

        Task<bool> SaveList(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);

        Task<bool> GetAllExt(Kns_Tran_RegFamilyInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegFamilyInfoResponse> outputPort);


    }
}
