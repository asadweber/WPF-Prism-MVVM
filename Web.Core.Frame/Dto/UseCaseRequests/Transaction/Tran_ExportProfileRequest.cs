using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Transaction
{
    public partial class Tran_ExportProfileRequest : IUseCaseRequest<Tran_ExportProfileResponse>
    {
        public tran_exportprofileEntity Objtran_exportprofile { get; }

        public Tran_ExportProfileRequest(tran_exportprofileEntity objtran_exportprofile)
        {
            Objtran_exportprofile = objtran_exportprofile;
        }
    }
}
