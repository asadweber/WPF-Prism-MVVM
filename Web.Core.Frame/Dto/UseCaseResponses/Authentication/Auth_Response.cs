using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public class Auth_Response : UseCaseResponseMessage
    {
        public owin_userEntity _owin_userEntity { get; }
        public AjaxResponse _ajaxresponse { get; }


        public IEnumerable<owin_userEntity> _owin_userEntityList { get; }

        public Error Errors { get; }


        public Auth_Response(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }


        public Auth_Response(IEnumerable<owin_userEntity> owin_userEntityList, bool success = false, string message = null) : base(success, message)
        {
            _owin_userEntityList = owin_userEntityList;
        }
        
        public Auth_Response(owin_userEntity owin_userEntity, bool success = false, string message = null) : base(success, message)
        {
            _owin_userEntity = owin_userEntity;
        }

        public Auth_Response(AjaxResponse azaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = azaxresponse;
        }
    }
}
