using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_PhaseInfoNotificationResponse : UseCaseResponseMessage
    {
        public kns_tran_phaseinfonotificationEntity _kns_TranPhaseInfoNotification { get; }

        public IEnumerable<kns_tran_phaseinfonotificationEntity> _kns_TranPhaseInfoNotificationList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_PhaseInfoNotificationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_PhaseInfoNotificationResponse(IEnumerable<kns_tran_phaseinfonotificationEntity> kns_TranPhaseInfoNotificationList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranPhaseInfoNotificationList = kns_TranPhaseInfoNotificationList;
        }
        
        public Kns_Tran_PhaseInfoNotificationResponse(kns_tran_phaseinfonotificationEntity kns_TranPhaseInfoNotification, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranPhaseInfoNotification = kns_TranPhaseInfoNotification;
        }

        public Kns_Tran_PhaseInfoNotificationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
