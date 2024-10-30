using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses
{
    public class RegisterUserResponse : UseCaseResponseMessage 
    {
        public KnsUserRegistrationEntity knsUserRegistrationEntity { get; set; }

        public string Id { get; }
        public Error Errors { get; }

        public BDO.Core.DataAccessObjects.ExtendedEntities.AjaxResponse _ajaxresponse { get; }



        public RegisterUserResponse( bool success=false, string message=null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public RegisterUserResponse(string id, bool success = false, string message = null) : base(success, message)
        {
            Id = id;
        }

        public RegisterUserResponse(KnsUserRegistrationEntity knsUserRegistrationEntity, bool success = false, string message = null) : base(success, message)
        {
            this.knsUserRegistrationEntity = knsUserRegistrationEntity;
        }

        public RegisterUserResponse(BDO.Core.DataAccessObjects.ExtendedEntities.AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }

        


    }
}
