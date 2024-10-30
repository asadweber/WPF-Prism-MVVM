using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_RegFamilyInfoResponse : UseCaseResponseMessage
    {
        public kns_tran_regfamilyinfoEntity _kns_TranRegFamilyInfo { get; }

        public IEnumerable<kns_tran_regfamilyinfoEntity> _kns_TranRegFamilyInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_RegFamilyInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_RegFamilyInfoResponse(IEnumerable<kns_tran_regfamilyinfoEntity> kns_TranRegFamilyInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegFamilyInfoList = kns_TranRegFamilyInfoList;
        }
        
        public Kns_Tran_RegFamilyInfoResponse(kns_tran_regfamilyinfoEntity kns_TranRegFamilyInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegFamilyInfo = kns_TranRegFamilyInfo;
        }

        public Kns_Tran_RegFamilyInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
