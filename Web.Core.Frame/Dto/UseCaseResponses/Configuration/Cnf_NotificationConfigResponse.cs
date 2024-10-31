using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_NotificationConfigResponse : UseCaseResponseMessage
    {
        public cnf_notificationconfigEntity _cnf_NotificationConfig { get; }

        public IEnumerable<cnf_notificationconfigEntity> _cnf_NotificationConfigList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_NotificationConfigResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_NotificationConfigResponse(IEnumerable<cnf_notificationconfigEntity> cnf_NotificationConfigList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_NotificationConfigList = cnf_NotificationConfigList;
        }

        public Cnf_NotificationConfigResponse(cnf_notificationconfigEntity cnf_NotificationConfig, bool success = false, string message = null) : base(success, message)
        {
            _cnf_NotificationConfig = cnf_NotificationConfig;
        }

        public Cnf_NotificationConfigResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
