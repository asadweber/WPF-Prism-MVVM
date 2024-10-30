using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_ImportFromPaciExcelRequest : IUseCaseRequest<Kns_ImportFromPaciExcelResponse>
    {
        public kns_importfrompaciexcelEntity Objkns_importfrompaciexcel { get; }
        
        public Kns_ImportFromPaciExcelRequest(kns_importfrompaciexcelEntity objkns_importfrompaciexcel)
        {
            Objkns_importfrompaciexcel = objkns_importfrompaciexcel;
        }
    }
}
