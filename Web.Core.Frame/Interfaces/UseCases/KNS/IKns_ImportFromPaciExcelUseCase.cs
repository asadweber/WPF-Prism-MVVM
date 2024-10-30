using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_ImportFromPaciExcelUseCase : IUseCaseRequestHandler<Kns_ImportFromPaciExcelRequest, Kns_ImportFromPaciExcelResponse>
    {
        Task<bool> Save(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);

        Task<bool> Update(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);

        Task<bool> Delete(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);


        Task<bool> GetSingle(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);

        Task<bool> GetAll(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);


        Task<bool> GetAllPaged(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);

        Task<bool> GetListView(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);
        
        
            
    }
}
