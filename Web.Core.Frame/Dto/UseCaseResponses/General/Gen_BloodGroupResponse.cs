using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_BloodGroupResponse : UseCaseResponseMessage
    {
        public gen_bloodgroupEntity _gen_BloodGroup { get; }

        public IEnumerable<gen_bloodgroupEntity> _gen_BloodGroupList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_BloodGroupResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_BloodGroupResponse(IEnumerable<gen_bloodgroupEntity> gen_BloodGroupList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BloodGroupList = gen_BloodGroupList;
        }
        
        public Gen_BloodGroupResponse(gen_bloodgroupEntity gen_BloodGroup, bool success = false, string message = null) : base(success, message)
        {
            _gen_BloodGroup = gen_BloodGroup;
        }

        public Gen_BloodGroupResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
