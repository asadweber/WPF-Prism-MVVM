using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_PhasesResponse : UseCaseResponseMessage
    {
        public gen_phasesEntity _gen_Phases { get; }

        public IEnumerable<gen_phasesEntity> _gen_PhasesList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_PhasesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_PhasesResponse(IEnumerable<gen_phasesEntity> gen_PhasesList, bool success = false, string message = null) : base(success, message)
        {
            _gen_PhasesList = gen_PhasesList;
        }
        
        public Gen_PhasesResponse(gen_phasesEntity gen_Phases, bool success = false, string message = null) : base(success, message)
        {
            _gen_Phases = gen_Phases;
        }

        public Gen_PhasesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
