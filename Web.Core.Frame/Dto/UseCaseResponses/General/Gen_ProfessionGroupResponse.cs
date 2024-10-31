using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ProfessionGroupResponse : UseCaseResponseMessage
    {
        public gen_professiongroupEntity _gen_ProfessionGroup { get; }

        public IEnumerable<gen_professiongroupEntity> _gen_ProfessionGroupList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ProfessionGroupResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ProfessionGroupResponse(IEnumerable<gen_professiongroupEntity> gen_ProfessionGroupList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ProfessionGroupList = gen_ProfessionGroupList;
        }
        
        public Gen_ProfessionGroupResponse(gen_professiongroupEntity gen_ProfessionGroup, bool success = false, string message = null) : base(success, message)
        {
            _gen_ProfessionGroup = gen_ProfessionGroup;
        }

        public Gen_ProfessionGroupResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
