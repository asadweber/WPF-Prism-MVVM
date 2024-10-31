using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_SyExamNotificationResponse : UseCaseResponseMessage
    {
        public tran_syexamnotificationEntity _tran_SyExamNotification { get; }

        public IEnumerable<tran_syexamnotificationEntity> _tran_SyExamNotificationList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Tran_SyExamNotificationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_SyExamNotificationResponse(IEnumerable<tran_syexamnotificationEntity> tran_SyExamNotificationList, bool success = false, string message = null) : base(success, message)
        {
            _tran_SyExamNotificationList = tran_SyExamNotificationList;
        }
        
        public Tran_SyExamNotificationResponse(tran_syexamnotificationEntity tran_SyExamNotification, bool success = false, string message = null) : base(success, message)
        {
            _tran_SyExamNotification = tran_SyExamNotification;
        }

        public Tran_SyExamNotificationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
