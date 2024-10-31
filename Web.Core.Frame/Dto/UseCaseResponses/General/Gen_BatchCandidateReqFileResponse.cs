using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_BatchCandidateReqFileResponse : UseCaseResponseMessage
    {
        public gen_batchcandidatereqfileEntity _gen_BatchCandidateReqFile { get; }

        public IEnumerable<gen_batchcandidatereqfileEntity> _gen_BatchCandidateReqFileList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_BatchCandidateReqFileResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_BatchCandidateReqFileResponse(IEnumerable<gen_batchcandidatereqfileEntity> gen_BatchCandidateReqFileList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandidateReqFileList = gen_BatchCandidateReqFileList;
        }
        
        public Gen_BatchCandidateReqFileResponse(gen_batchcandidatereqfileEntity gen_BatchCandidateReqFile, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandidateReqFile = gen_BatchCandidateReqFile;
        }

        public Gen_BatchCandidateReqFileResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
