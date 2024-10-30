using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_UserPasswordResetInfoResponse : UseCaseResponseMessage
    {
        public owin_userpasswordresetinfoEntity _owin_UserPasswordResetInfo { get; }

        public IEnumerable<owin_userpasswordresetinfoEntity> _owin_UserPasswordResetInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_UserPasswordResetInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_UserPasswordResetInfoResponse(IEnumerable<owin_userpasswordresetinfoEntity> owin_UserPasswordResetInfoList, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserPasswordResetInfoList = owin_UserPasswordResetInfoList;
        }
        
        public Owin_UserPasswordResetInfoResponse(owin_userpasswordresetinfoEntity owin_UserPasswordResetInfo, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserPasswordResetInfo = owin_UserPasswordResetInfo;
        }

        public Owin_UserPasswordResetInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
