using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ITran_RecievePaciDataInfoUseCase : IUseCaseRequestHandler<Tran_RecievePaciDataInfoRequest, Tran_RecievePaciDataInfoResponse>
    {
        Task<bool> Save(Tran_RecievePaciDataInfoRequest message, ICRUDRequestHandler<Tran_RecievePaciDataInfoResponse> outputPort);

        Task<bool> Update(Tran_RecievePaciDataInfoRequest message, ICRUDRequestHandler<Tran_RecievePaciDataInfoResponse> outputPort);

        Task<bool> Delete(Tran_RecievePaciDataInfoRequest message, ICRUDRequestHandler<Tran_RecievePaciDataInfoResponse> outputPort);


        Task<bool> GetSingle(Tran_RecievePaciDataInfoRequest message, ICRUDRequestHandler<Tran_RecievePaciDataInfoResponse> outputPort);

        Task<bool> GetAll(Tran_RecievePaciDataInfoRequest message, ICRUDRequestHandler<Tran_RecievePaciDataInfoResponse> outputPort);


        Task<bool> GetAllPaged(Tran_RecievePaciDataInfoRequest message, ICRUDRequestHandler<Tran_RecievePaciDataInfoResponse> outputPort);

        Task<bool> GetListView(Tran_RecievePaciDataInfoRequest message, ICRUDRequestHandler<Tran_RecievePaciDataInfoResponse> outputPort);
        
        
            
    }
}
