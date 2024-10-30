using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_StatusChangeRequestResolutionResponse : UseCaseResponseMessage
    {
        public kns_statuschangerequestresolutionEntity _kns_StatusChangeRequestResolution { get; }

        public IEnumerable<kns_statuschangerequestresolutionEntity> _kns_StatusChangeRequestResolutionList { get; }
        public IEnumerable<kns_tran_registrationprofileEntity> _kns_tran_registrationprofileList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_StatusChangeRequestResolutionResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_StatusChangeRequestResolutionResponse(IEnumerable<kns_statuschangerequestresolutionEntity> kns_StatusChangeRequestResolutionList, bool success = false, string message = null) : base(success, message)
        {
            _kns_StatusChangeRequestResolutionList = kns_StatusChangeRequestResolutionList;
        }
        public Kns_StatusChangeRequestResolutionResponse(IEnumerable<kns_tran_registrationprofileEntity> kns_StatusChangeRequestResolutionList, bool success = false, string message = null) : base(success, message)
        {
            _kns_tran_registrationprofileList = kns_StatusChangeRequestResolutionList;
        }
        
        public Kns_StatusChangeRequestResolutionResponse(kns_statuschangerequestresolutionEntity kns_StatusChangeRequestResolution, bool success = false, string message = null) : base(success, message)
        {
            _kns_StatusChangeRequestResolution = kns_StatusChangeRequestResolution;
        }

        public Kns_StatusChangeRequestResolutionResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
