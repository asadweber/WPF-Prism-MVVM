using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_NotificationConfigDetlResponse : UseCaseResponseMessage
    {
        public cnf_notificationconfigdetlEntity _cnf_NotificationConfigDetl { get; }

        public IEnumerable<cnf_notificationconfigdetlEntity> _cnf_NotificationConfigDetlList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_NotificationConfigDetlResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_NotificationConfigDetlResponse(IEnumerable<cnf_notificationconfigdetlEntity> cnf_NotificationConfigDetlList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_NotificationConfigDetlList = cnf_NotificationConfigDetlList;
        }

        public Cnf_NotificationConfigDetlResponse(cnf_notificationconfigdetlEntity cnf_NotificationConfigDetl, bool success = false, string message = null) : base(success, message)
        {
            _cnf_NotificationConfigDetl = cnf_NotificationConfigDetl;
        }

        public Cnf_NotificationConfigDetlResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
