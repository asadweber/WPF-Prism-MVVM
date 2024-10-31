using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_TrainingJoinNotificationResponse : UseCaseResponseMessage
    {
        public tran_trainingjoinnotificationEntity _tran_TrainingJoinNotification { get; }

        public IEnumerable<tran_trainingjoinnotificationEntity> _tran_TrainingJoinNotificationList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_TrainingJoinNotificationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_TrainingJoinNotificationResponse(IEnumerable<tran_trainingjoinnotificationEntity> tran_TrainingJoinNotificationList, bool success = false, string message = null) : base(success, message)
        {
            _tran_TrainingJoinNotificationList = tran_TrainingJoinNotificationList;
        }

        public Tran_TrainingJoinNotificationResponse(tran_trainingjoinnotificationEntity tran_TrainingJoinNotification, bool success = false, string message = null) : base(success, message)
        {
            _tran_TrainingJoinNotification = tran_TrainingJoinNotification;
        }

        public Tran_TrainingJoinNotificationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
