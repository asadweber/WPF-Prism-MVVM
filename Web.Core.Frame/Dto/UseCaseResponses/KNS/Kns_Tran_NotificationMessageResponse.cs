using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_NotificationMessageResponse : UseCaseResponseMessage
    {
        public kns_tran_notificationmessageEntity _kns_TranNotificationMessage { get; }

        public IEnumerable<kns_tran_notificationmessageEntity> _kns_TranNotificationMessageList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_NotificationMessageResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_NotificationMessageResponse(IEnumerable<kns_tran_notificationmessageEntity> kns_TranNotificationMessageList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranNotificationMessageList = kns_TranNotificationMessageList;
        }
        
        public Kns_Tran_NotificationMessageResponse(kns_tran_notificationmessageEntity kns_TranNotificationMessage, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranNotificationMessage = kns_TranNotificationMessage;
        }

        public Kns_Tran_NotificationMessageResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
