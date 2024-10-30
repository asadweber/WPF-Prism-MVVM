using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_RegExternalServiceResultInfoResponse : UseCaseResponseMessage
    {
        public kns_tran_regexternalserviceresultinfoEntity _kns_TranRegExternalServiceResultInfo { get; }

        public IEnumerable<kns_tran_regexternalserviceresultinfoEntity> _kns_TranRegExternalServiceResultInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_RegExternalServiceResultInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_RegExternalServiceResultInfoResponse(IEnumerable<kns_tran_regexternalserviceresultinfoEntity> kns_TranRegExternalServiceResultInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegExternalServiceResultInfoList = kns_TranRegExternalServiceResultInfoList;
        }
        
        public Kns_Tran_RegExternalServiceResultInfoResponse(kns_tran_regexternalserviceresultinfoEntity kns_TranRegExternalServiceResultInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegExternalServiceResultInfo = kns_TranRegExternalServiceResultInfo;
        }

        public Kns_Tran_RegExternalServiceResultInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
