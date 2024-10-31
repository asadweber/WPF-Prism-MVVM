using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_NotificationFileResponse : UseCaseResponseMessage
    {
        public tran_notificationfileEntity _tran_NotificationFile { get; }

        public IEnumerable<tran_notificationfileEntity> _tran_NotificationFileList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Tran_NotificationFileResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_NotificationFileResponse(IEnumerable<tran_notificationfileEntity> tran_NotificationFileList, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationFileList = tran_NotificationFileList;
        }
        
        public Tran_NotificationFileResponse(tran_notificationfileEntity tran_NotificationFile, bool success = false, string message = null) : base(success, message)
        {
            _tran_NotificationFile = tran_NotificationFile;
        }

        public Tran_NotificationFileResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
