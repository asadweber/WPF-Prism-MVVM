using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Transaction
{
    public partial class Tran_NotificationBatchResponse : UseCaseResponseMessage
    {
        public tran_notificationbatchEntity _tran_NotificationBatch { get; }

        public IEnumerable<tran_notificationbatchEntity> _tran_NotificationBatchList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_NotificationBatchResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_NotificationBatchResponse(IEnumerable<tran_notificationbatchEntity> tran_NotificationBatchList, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationBatchList = tran_NotificationBatchList;
        }

        public Tran_NotificationBatchResponse(tran_notificationbatchEntity tran_NotificationBatch, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationBatch = tran_NotificationBatch;
        }

        public Tran_NotificationBatchResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
