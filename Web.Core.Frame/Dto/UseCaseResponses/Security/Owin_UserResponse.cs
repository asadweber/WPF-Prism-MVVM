using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_UserResponse : UseCaseResponseMessage
    {
        public owin_userEntity _owin_User { get; }

        public IEnumerable<owin_userEntity> _owin_UserList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_UserResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_UserResponse(IEnumerable<owin_userEntity> owin_UserList, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserList = owin_UserList;
        }
        
        public Owin_UserResponse(owin_userEntity owin_User, bool success = false, string message = null) : base(success, message)
        {
            _owin_User = owin_User;
        }

        public Owin_UserResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
