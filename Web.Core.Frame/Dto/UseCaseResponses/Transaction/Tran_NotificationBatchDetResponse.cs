using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Transaction
{
    public partial class Tran_NotificationBatchDetResponse : UseCaseResponseMessage
    {
        public tran_notificationbatchdetEntity _tran_NotificationBatchDet { get; }

        public IEnumerable<tran_notificationbatchdetEntity> _tran_NotificationBatchDetList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_NotificationBatchDetResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_NotificationBatchDetResponse(IEnumerable<tran_notificationbatchdetEntity> tran_NotificationBatchDetList, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationBatchDetList = tran_NotificationBatchDetList;
        }

        public Tran_NotificationBatchDetResponse(tran_notificationbatchdetEntity tran_NotificationBatchDet, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationBatchDet = tran_NotificationBatchDet;
        }

        public Tran_NotificationBatchDetResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
