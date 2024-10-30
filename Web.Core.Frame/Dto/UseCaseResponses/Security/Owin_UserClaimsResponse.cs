using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_UserClaimsResponse : UseCaseResponseMessage
    {
        public owin_userclaimsEntity _owin_UserClaims { get; }

        public IEnumerable<owin_userclaimsEntity> _owin_UserClaimsList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_UserClaimsResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_UserClaimsResponse(IEnumerable<owin_userclaimsEntity> owin_UserClaimsList, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserClaimsList = owin_UserClaimsList;
        }
        
        public Owin_UserClaimsResponse(owin_userclaimsEntity owin_UserClaims, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserClaims = owin_UserClaims;
        }

        public Owin_UserClaimsResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
