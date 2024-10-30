using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_PhaseInfo_NotificationCountResponse : UseCaseResponseMessage
    {
        public kns_tran_phaseinfo_notificationcountEntity _kns_tran_phaseinfo_notificationcount { get; }

        public IEnumerable<kns_tran_phaseinfo_notificationcountEntity> _kns_tran_phaseinfo_notificationcountList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_PhaseInfo_NotificationCountResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_PhaseInfo_NotificationCountResponse(IEnumerable<kns_tran_phaseinfo_notificationcountEntity> kns_tran_phaseinfo_notificationcountList, bool success = false, string message = null) : base(success, message)
        {
			_kns_tran_phaseinfo_notificationcountList = kns_tran_phaseinfo_notificationcountList;
        }
        
        public Kns_Tran_PhaseInfo_NotificationCountResponse(kns_tran_phaseinfo_notificationcountEntity kns_tran_phaseinfo_notificationcount, bool success = false, string message = null) : base(success, message)
        {
			_kns_tran_phaseinfo_notificationcount = kns_tran_phaseinfo_notificationcount;
        }

        public Kns_Tran_PhaseInfo_NotificationCountResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
