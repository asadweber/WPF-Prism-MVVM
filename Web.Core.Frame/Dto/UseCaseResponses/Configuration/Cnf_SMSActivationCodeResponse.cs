using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_SMSActivationCodeResponse : UseCaseResponseMessage
    {
        public cnf_smsactivationcodeEntity _cnf_SMSActivationCode { get; }

        public IEnumerable<cnf_smsactivationcodeEntity> _cnf_SMSActivationCodeList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_SMSActivationCodeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_SMSActivationCodeResponse(IEnumerable<cnf_smsactivationcodeEntity> cnf_SMSActivationCodeList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_SMSActivationCodeList = cnf_SMSActivationCodeList;
        }

        public Cnf_SMSActivationCodeResponse(cnf_smsactivationcodeEntity cnf_SMSActivationCode, bool success = false, string message = null) : base(success, message)
        {
            _cnf_SMSActivationCode = cnf_SMSActivationCode;
        }

        public Cnf_SMSActivationCodeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
