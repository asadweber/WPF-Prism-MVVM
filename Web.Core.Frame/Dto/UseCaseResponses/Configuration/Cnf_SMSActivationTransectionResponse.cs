using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_SMSActivationTransectionResponse : UseCaseResponseMessage
    {
        public cnf_smsactivationtransectionEntity _cnf_SMSActivationTransection { get; }

        public IEnumerable<cnf_smsactivationtransectionEntity> _cnf_SMSActivationTransectionList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_SMSActivationTransectionResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_SMSActivationTransectionResponse(IEnumerable<cnf_smsactivationtransectionEntity> cnf_SMSActivationTransectionList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_SMSActivationTransectionList = cnf_SMSActivationTransectionList;
        }

        public Cnf_SMSActivationTransectionResponse(cnf_smsactivationtransectionEntity cnf_SMSActivationTransection, bool success = false, string message = null) : base(success, message)
        {
            _cnf_SMSActivationTransection = cnf_SMSActivationTransection;
        }

        public Cnf_SMSActivationTransectionResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
