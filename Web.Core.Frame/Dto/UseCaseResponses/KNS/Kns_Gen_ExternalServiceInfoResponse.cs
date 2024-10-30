using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_ExternalServiceInfoResponse : UseCaseResponseMessage
    {
        public kns_gen_externalserviceinfoEntity _kns_GenExternalServiceInfo { get; }

        public IEnumerable<kns_gen_externalserviceinfoEntity> _kns_GenExternalServiceInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_ExternalServiceInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_ExternalServiceInfoResponse(IEnumerable<kns_gen_externalserviceinfoEntity> kns_GenExternalServiceInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenExternalServiceInfoList = kns_GenExternalServiceInfoList;
        }
        
        public Kns_Gen_ExternalServiceInfoResponse(kns_gen_externalserviceinfoEntity kns_GenExternalServiceInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenExternalServiceInfo = kns_GenExternalServiceInfo;
        }

        public Kns_Gen_ExternalServiceInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
