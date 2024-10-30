using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_UserRoleResponse : UseCaseResponseMessage
    {
        public owin_userroleEntity _owin_UserRole { get; }

        public IEnumerable<owin_userroleEntity> _owin_UserRoleList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_UserRoleResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_UserRoleResponse(IEnumerable<owin_userroleEntity> owin_UserRoleList, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserRoleList = owin_UserRoleList;
        }
        
        public Owin_UserRoleResponse(owin_userroleEntity owin_UserRole, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserRole = owin_UserRole;
        }

        public Owin_UserRoleResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
