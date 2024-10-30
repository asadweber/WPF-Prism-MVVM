using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_IssueTypeResponse : UseCaseResponseMessage
    {
        public gen_issuetypeEntity _gen_IssueType { get; }

        public IEnumerable<gen_issuetypeEntity> _gen_IssueTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_IssueTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_IssueTypeResponse(IEnumerable<gen_issuetypeEntity> gen_IssueTypeList, bool success = false, string message = null) : base(success, message)
        {
            _gen_IssueTypeList = gen_IssueTypeList;
        }
        
        public Gen_IssueTypeResponse(gen_issuetypeEntity gen_IssueType, bool success = false, string message = null) : base(success, message)
        {
            _gen_IssueType = gen_IssueType;
        }

        public Gen_IssueTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
