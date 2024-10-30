using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_RegEducationInfoResponse : UseCaseResponseMessage
    {
        public kns_tran_regeducationinfoEntity _kns_TranRegEducationInfo { get; }

        public IEnumerable<kns_tran_regeducationinfoEntity> _kns_TranRegEducationInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_RegEducationInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_RegEducationInfoResponse(IEnumerable<kns_tran_regeducationinfoEntity> kns_TranRegEducationInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegEducationInfoList = kns_TranRegEducationInfoList;
        }
        
        public Kns_Tran_RegEducationInfoResponse(kns_tran_regeducationinfoEntity kns_TranRegEducationInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegEducationInfo = kns_TranRegEducationInfo;
        }

        public Kns_Tran_RegEducationInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
