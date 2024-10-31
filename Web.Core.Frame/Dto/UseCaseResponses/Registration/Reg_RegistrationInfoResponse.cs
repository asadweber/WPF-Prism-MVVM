using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_RegistrationInfoResponse : UseCaseResponseMessage
    {
        public reg_registrationinfoEntity _reg_RegistrationInfo { get; }

        public IEnumerable<reg_registrationinfoEntity> _reg_RegistrationInfoList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_RegistrationInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_RegistrationInfoResponse(IEnumerable<reg_registrationinfoEntity> reg_RegistrationInfoList, bool success = false, string message = null) : base(success, message)
        {
            _reg_RegistrationInfoList = reg_RegistrationInfoList;
        }

        public Reg_RegistrationInfoResponse(reg_registrationinfoEntity reg_RegistrationInfo, bool success = false, string message = null) : base(success, message)
        {
            _reg_RegistrationInfo = reg_RegistrationInfo;
        }

        public Reg_RegistrationInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
