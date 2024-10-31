using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CandidateTypeResponse : UseCaseResponseMessage
    {
        public gen_candidatetypeEntity _gen_CandidateType { get; }

        public IEnumerable<gen_candidatetypeEntity> _gen_CandidateTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CandidateTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CandidateTypeResponse(IEnumerable<gen_candidatetypeEntity> gen_CandidateTypeList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CandidateTypeList = gen_CandidateTypeList;
        }
        
        public Gen_CandidateTypeResponse(gen_candidatetypeEntity gen_CandidateType, bool success = false, string message = null) : base(success, message)
        {
            _gen_CandidateType = gen_CandidateType;
        }

        public Gen_CandidateTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
