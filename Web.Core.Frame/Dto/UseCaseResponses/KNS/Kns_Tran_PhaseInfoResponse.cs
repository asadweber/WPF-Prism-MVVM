using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_PhaseInfoResponse : UseCaseResponseMessage
    {
        public kns_tran_phaseinfoEntity _kns_TranPhaseInfo { get; }

        public IEnumerable<kns_tran_phaseinfoEntity> _kns_TranPhaseInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_PhaseInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_PhaseInfoResponse(IEnumerable<kns_tran_phaseinfoEntity> kns_TranPhaseInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranPhaseInfoList = kns_TranPhaseInfoList;
        }
        
        public Kns_Tran_PhaseInfoResponse(kns_tran_phaseinfoEntity kns_TranPhaseInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranPhaseInfo = kns_TranPhaseInfo;
        }

        public Kns_Tran_PhaseInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
