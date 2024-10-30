using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_RegImergencyContactInfoResponse : UseCaseResponseMessage
    {
        public kns_tran_regimergencycontactinfoEntity _kns_TranRegImergencyContactInfo { get; }

        public IEnumerable<kns_tran_regimergencycontactinfoEntity> _kns_TranRegImergencyContactInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_RegImergencyContactInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_RegImergencyContactInfoResponse(IEnumerable<kns_tran_regimergencycontactinfoEntity> kns_TranRegImergencyContactInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegImergencyContactInfoList = kns_TranRegImergencyContactInfoList;
        }
        
        public Kns_Tran_RegImergencyContactInfoResponse(kns_tran_regimergencycontactinfoEntity kns_TranRegImergencyContactInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegImergencyContactInfo = kns_TranRegImergencyContactInfo;
        }

        public Kns_Tran_RegImergencyContactInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
