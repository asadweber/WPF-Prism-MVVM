using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_RegistrationProfileFileStorageResponse : UseCaseResponseMessage
    {
        public kns_tran_registrationprofilefilestorageEntity _kns_TranRegistrationProfileFileStorage { get; }

        public IEnumerable<kns_tran_registrationprofilefilestorageEntity> _kns_TranRegistrationProfileFileStorageList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_RegistrationProfileFileStorageResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_RegistrationProfileFileStorageResponse(IEnumerable<kns_tran_registrationprofilefilestorageEntity> kns_TranRegistrationProfileFileStorageList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegistrationProfileFileStorageList = kns_TranRegistrationProfileFileStorageList;
        }
        
        public Kns_Tran_RegistrationProfileFileStorageResponse(kns_tran_registrationprofilefilestorageEntity kns_TranRegistrationProfileFileStorage, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegistrationProfileFileStorage = kns_TranRegistrationProfileFileStorage;
        }

        public Kns_Tran_RegistrationProfileFileStorageResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
