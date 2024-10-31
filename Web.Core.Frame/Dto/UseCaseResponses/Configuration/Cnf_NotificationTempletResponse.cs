using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Configuration
{
    public partial class Cnf_NotificationTempletResponse : UseCaseResponseMessage
    {
        public cnf_notificationtempletEntity _cnf_NotificationTemplet { get; }

        public IEnumerable<cnf_notificationtempletEntity> _cnf_NotificationTempletList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Cnf_NotificationTempletResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Cnf_NotificationTempletResponse(IEnumerable<cnf_notificationtempletEntity> cnf_NotificationTempletList, bool success = false, string message = null) : base(success, message)
        {
            _cnf_NotificationTempletList = cnf_NotificationTempletList;
        }

        public Cnf_NotificationTempletResponse(cnf_notificationtempletEntity cnf_NotificationTemplet, bool success = false, string message = null) : base(success, message)
        {
            _cnf_NotificationTemplet = cnf_NotificationTemplet;
        }

        public Cnf_NotificationTempletResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
