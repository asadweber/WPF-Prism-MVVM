using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_BatchCandidateTypeMapResponse : UseCaseResponseMessage
    {
        public gen_batchcandidatetypemapEntity _gen_BatchCandidateTypeMap { get; }

        public IEnumerable<gen_batchcandidatetypemapEntity> _gen_BatchCandidateTypeMapList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_BatchCandidateTypeMapResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_BatchCandidateTypeMapResponse(IEnumerable<gen_batchcandidatetypemapEntity> gen_BatchCandidateTypeMapList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandidateTypeMapList = gen_BatchCandidateTypeMapList;
        }
        
        public Gen_BatchCandidateTypeMapResponse(gen_batchcandidatetypemapEntity gen_BatchCandidateTypeMap, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandidateTypeMap = gen_BatchCandidateTypeMap;
        }

        public Gen_BatchCandidateTypeMapResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
