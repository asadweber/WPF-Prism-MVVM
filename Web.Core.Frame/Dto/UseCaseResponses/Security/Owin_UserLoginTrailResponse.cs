using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_UserLoginTrailResponse : UseCaseResponseMessage
    {
        public owin_userlogintrailEntity _owin_UserLoginTrail { get; }

        public IEnumerable<owin_userlogintrailEntity> _owin_UserLoginTrailList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_UserLoginTrailResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_UserLoginTrailResponse(IEnumerable<owin_userlogintrailEntity> owin_UserLoginTrailList, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserLoginTrailList = owin_UserLoginTrailList;
        }
        
        public Owin_UserLoginTrailResponse(owin_userlogintrailEntity owin_UserLoginTrail, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserLoginTrail = owin_UserLoginTrail;
        }

        public Owin_UserLoginTrailResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
