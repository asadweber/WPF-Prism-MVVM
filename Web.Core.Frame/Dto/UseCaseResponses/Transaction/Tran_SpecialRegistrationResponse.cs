using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Transaction
{
    public partial class Tran_SpecialRegistrationResponse : UseCaseResponseMessage
    {
        public tran_specialregistrationEntity _tran_SpecialRegistration { get; }

        public IEnumerable<tran_specialregistrationEntity> _tran_SpecialRegistrationList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_SpecialRegistrationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_SpecialRegistrationResponse(IEnumerable<tran_specialregistrationEntity> tran_SpecialRegistrationList, bool success = false, string message = null) : base(success, message)
        {
            _tran_SpecialRegistrationList = tran_SpecialRegistrationList;
        }

        public Tran_SpecialRegistrationResponse(tran_specialregistrationEntity tran_SpecialRegistration, bool success = false, string message = null) : base(success, message)
        {
            _tran_SpecialRegistration = tran_SpecialRegistration;
        }

        public Tran_SpecialRegistrationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
