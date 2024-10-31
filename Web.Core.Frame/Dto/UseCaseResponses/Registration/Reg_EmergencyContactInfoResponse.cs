using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_EmergencyContactInfoResponse : UseCaseResponseMessage
    {
        public reg_emergencycontactinfoEntity _reg_EmergencyContactInfo { get; }

        public IEnumerable<reg_emergencycontactinfoEntity> _reg_EmergencyContactInfoList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_EmergencyContactInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_EmergencyContactInfoResponse(IEnumerable<reg_emergencycontactinfoEntity> reg_EmergencyContactInfoList, bool success = false, string message = null) : base(success, message)
        {
            _reg_EmergencyContactInfoList = reg_EmergencyContactInfoList;
        }

        public Reg_EmergencyContactInfoResponse(reg_emergencycontactinfoEntity reg_EmergencyContactInfo, bool success = false, string message = null) : base(success, message)
        {
            _reg_EmergencyContactInfo = reg_EmergencyContactInfo;
        }

        public Reg_EmergencyContactInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
