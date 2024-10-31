using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_StudentFileStorageRequest : IUseCaseRequest<Reg_StudentFileStorageResponse>
    {
        public reg_studentfilestorageEntity Objreg_studentfilestorage { get; }

        public Reg_StudentFileStorageRequest(reg_studentfilestorageEntity objreg_studentfilestorage)
        {
            Objreg_studentfilestorage = objreg_studentfilestorage;
        }
    }
}
