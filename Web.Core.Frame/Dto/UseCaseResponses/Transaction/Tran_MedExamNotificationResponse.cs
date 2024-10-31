using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_MedExamNotificationResponse : UseCaseResponseMessage
    {
        public tran_medexamnotificationEntity _tran_MedExamNotification { get; }

        public IEnumerable<tran_medexamnotificationEntity> _tran_MedExamNotificationList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Tran_MedExamNotificationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_MedExamNotificationResponse(IEnumerable<tran_medexamnotificationEntity> tran_MedExamNotificationList, bool success = false, string message = null) : base(success, message)
        {
            _tran_MedExamNotificationList = tran_MedExamNotificationList;
        }
        
        public Tran_MedExamNotificationResponse(tran_medexamnotificationEntity tran_MedExamNotification, bool success = false, string message = null) : base(success, message)
        {
            _tran_MedExamNotification = tran_MedExamNotification;
        }

        public Tran_MedExamNotificationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
