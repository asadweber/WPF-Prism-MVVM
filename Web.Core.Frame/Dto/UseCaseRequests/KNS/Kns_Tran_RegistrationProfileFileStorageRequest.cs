using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_RegistrationProfileFileStorageRequest : IUseCaseRequest<Kns_Tran_RegistrationProfileFileStorageResponse>
    {
        public kns_tran_registrationprofilefilestorageEntity Objkns_tran_registrationprofilefilestorage { get; }
        
        public Kns_Tran_RegistrationProfileFileStorageRequest(kns_tran_registrationprofilefilestorageEntity objkns_tran_registrationprofilefilestorage)
        {
            Objkns_tran_registrationprofilefilestorage = objkns_tran_registrationprofilefilestorage;
        }
    }
}
