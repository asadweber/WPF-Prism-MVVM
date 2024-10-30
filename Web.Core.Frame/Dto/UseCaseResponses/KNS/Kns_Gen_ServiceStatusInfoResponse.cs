using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_ServiceStatusInfoResponse : UseCaseResponseMessage
    {
        public kns_gen_servicestatusinfoEntity _kns_GenServiceStatusInfo { get; }

        public IEnumerable<kns_gen_servicestatusinfoEntity> _kns_GenServiceStatusInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_ServiceStatusInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_ServiceStatusInfoResponse(IEnumerable<kns_gen_servicestatusinfoEntity> kns_GenServiceStatusInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenServiceStatusInfoList = kns_GenServiceStatusInfoList;
        }
        
        public Kns_Gen_ServiceStatusInfoResponse(kns_gen_servicestatusinfoEntity kns_GenServiceStatusInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenServiceStatusInfo = kns_GenServiceStatusInfo;
        }

        public Kns_Gen_ServiceStatusInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
