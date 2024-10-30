using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_ServiceStatusMapInfoResponse : UseCaseResponseMessage
    {
        public kns_servicestatusmapinfoEntity _kns_ServiceStatusMapInfo { get; }

        public IEnumerable<kns_servicestatusmapinfoEntity> _kns_ServiceStatusMapInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_ServiceStatusMapInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_ServiceStatusMapInfoResponse(IEnumerable<kns_servicestatusmapinfoEntity> kns_ServiceStatusMapInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_ServiceStatusMapInfoList = kns_ServiceStatusMapInfoList;
        }
        
        public Kns_ServiceStatusMapInfoResponse(kns_servicestatusmapinfoEntity kns_ServiceStatusMapInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_ServiceStatusMapInfo = kns_ServiceStatusMapInfo;
        }

        public Kns_ServiceStatusMapInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
