using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_FinalExamNotificationResponse : UseCaseResponseMessage
    {
        public tran_finalexamnotificationEntity _tran_FinalExamNotification { get; }

        public IEnumerable<tran_finalexamnotificationEntity> _tran_FinalExamNotificationList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_FinalExamNotificationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_FinalExamNotificationResponse(IEnumerable<tran_finalexamnotificationEntity> tran_FinalExamNotificationList, bool success = false, string message = null) : base(success, message)
        {
            _tran_FinalExamNotificationList = tran_FinalExamNotificationList;
        }

        public Tran_FinalExamNotificationResponse(tran_finalexamnotificationEntity tran_FinalExamNotification, bool success = false, string message = null) : base(success, message)
        {
            _tran_FinalExamNotification = tran_FinalExamNotification;
        }

        public Tran_FinalExamNotificationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
