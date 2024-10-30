using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_StatusChangeRequestResponse : UseCaseResponseMessage
    {
        public kns_statuschangerequestEntity _kns_StatusChangeRequest { get; }

        public IEnumerable<kns_statuschangerequestEntity> _kns_StatusChangeRequestList { get; }

        public IEnumerable<statuschangerequestdetails> _statuschangerequestdetailsList { get; }


        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_StatusChangeRequestResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_StatusChangeRequestResponse(IEnumerable<kns_statuschangerequestEntity> kns_StatusChangeRequestList, bool success = false, string message = null) : base(success, message)
        {
            _kns_StatusChangeRequestList = kns_StatusChangeRequestList;
        }
        
        public Kns_StatusChangeRequestResponse(kns_statuschangerequestEntity kns_StatusChangeRequest, bool success = false, string message = null) : base(success, message)
        {
            _kns_StatusChangeRequest = kns_StatusChangeRequest;
        }

        public Kns_StatusChangeRequestResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }


        public Kns_StatusChangeRequestResponse(IEnumerable<statuschangerequestdetails> kns_StatusChangeRequestList, bool success = false, string message = null) : base(success, message)
        {
            _statuschangerequestdetailsList = kns_StatusChangeRequestList;
        }




    }
}
