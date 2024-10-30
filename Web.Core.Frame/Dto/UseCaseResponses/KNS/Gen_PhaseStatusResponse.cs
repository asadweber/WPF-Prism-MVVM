using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_PhaseStatusResponse : UseCaseResponseMessage
    {
        public gen_phasestatusEntity _gen_PhaseStatus { get; }

        public IEnumerable<gen_phasestatusEntity> _gen_PhaseStatusList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_PhaseStatusResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_PhaseStatusResponse(IEnumerable<gen_phasestatusEntity> gen_PhaseStatusList, bool success = false, string message = null) : base(success, message)
        {
            _gen_PhaseStatusList = gen_PhaseStatusList;
        }
        
        public Gen_PhaseStatusResponse(gen_phasestatusEntity gen_PhaseStatus, bool success = false, string message = null) : base(success, message)
        {
            _gen_PhaseStatus = gen_PhaseStatus;
        }

        public Gen_PhaseStatusResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
