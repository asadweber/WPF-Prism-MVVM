using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_UserStatusChangeHistoryResponse : UseCaseResponseMessage
    {
        public owin_userstatuschangehistoryEntity _owin_UserStatusChangeHistory { get; }

        public IEnumerable<owin_userstatuschangehistoryEntity> _owin_UserStatusChangeHistoryList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_UserStatusChangeHistoryResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_UserStatusChangeHistoryResponse(IEnumerable<owin_userstatuschangehistoryEntity> owin_UserStatusChangeHistoryList, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserStatusChangeHistoryList = owin_UserStatusChangeHistoryList;
        }
        
        public Owin_UserStatusChangeHistoryResponse(owin_userstatuschangehistoryEntity owin_UserStatusChangeHistory, bool success = false, string message = null) : base(success, message)
        {
            _owin_UserStatusChangeHistory = owin_UserStatusChangeHistory;
        }

        public Owin_UserStatusChangeHistoryResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
