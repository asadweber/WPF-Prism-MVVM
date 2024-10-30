using BDO.Core.DataAccessObjects.Models;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_ImportFromPaciExcelUseCase : IUseCaseRequestHandler<Kns_ImportFromPaciExcelRequest, Kns_ImportFromPaciExcelResponse>
    {
       
        Task<bool> ValiidatePaciCivilIDFromCD(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);

      
        Task<bool> GetPaciDataByCivilID(Kns_ImportFromPaciExcelRequest message, ICRUDRequestHandler<Kns_ImportFromPaciExcelResponse> outputPort);
            
    }
}
