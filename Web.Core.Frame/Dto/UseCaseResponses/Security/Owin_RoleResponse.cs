using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_RoleResponse : UseCaseResponseMessage
    {
        public owin_roleEntity _owin_Role { get; }

        public IEnumerable<owin_roleEntity> _owin_RoleList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_RoleResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_RoleResponse(IEnumerable<owin_roleEntity> owin_RoleList, bool success = false, string message = null) : base(success, message)
        {
            _owin_RoleList = owin_RoleList;
        }
        
        public Owin_RoleResponse(owin_roleEntity owin_Role, bool success = false, string message = null) : base(success, message)
        {
            _owin_Role = owin_Role;
        }

        public Owin_RoleResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
