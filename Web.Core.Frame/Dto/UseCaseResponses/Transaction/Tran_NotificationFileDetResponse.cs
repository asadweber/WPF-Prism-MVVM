using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_NotificationFileDetResponse : UseCaseResponseMessage
    {
        public tran_notificationfiledetEntity _tran_NotificationFileDet { get; }

        public IEnumerable<tran_notificationfiledetEntity> _tran_NotificationFileDetList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Tran_NotificationFileDetResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_NotificationFileDetResponse(IEnumerable<tran_notificationfiledetEntity> tran_NotificationFileDetList, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationFileDetList = tran_NotificationFileDetList;
        }
        
        public Tran_NotificationFileDetResponse(tran_notificationfiledetEntity tran_NotificationFileDet, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationFileDet = tran_NotificationFileDet;
        }

        public Tran_NotificationFileDetResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
