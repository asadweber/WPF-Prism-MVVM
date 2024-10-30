using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_ServiceInfoResponse : UseCaseResponseMessage
    {
        public kns_gen_serviceinfoEntity _kns_GenServiceInfo { get; }

        public IEnumerable<kns_gen_serviceinfoEntity> _kns_GenServiceInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_ServiceInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_ServiceInfoResponse(IEnumerable<kns_gen_serviceinfoEntity> kns_GenServiceInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenServiceInfoList = kns_GenServiceInfoList;
        }
        
        public Kns_Gen_ServiceInfoResponse(kns_gen_serviceinfoEntity kns_GenServiceInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenServiceInfo = kns_GenServiceInfo;
        }

        public Kns_Gen_ServiceInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
