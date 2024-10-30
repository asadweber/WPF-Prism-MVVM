using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_UserRolesResponse : UseCaseResponseMessage
    {
        public owin_userrolesEntity _owin_UserRoles { get; }

        public IEnumerable<owin_userrolesEntity> _owin_UserRolesList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_UserRolesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_UserRolesResponse(IEnumerable<owin_userrolesEntity> owin_UserRolesList, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserRolesList = owin_UserRolesList;
        }
        
        public Owin_UserRolesResponse(owin_userrolesEntity owin_UserRoles, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserRoles = owin_UserRoles;
        }

        public Owin_UserRolesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
