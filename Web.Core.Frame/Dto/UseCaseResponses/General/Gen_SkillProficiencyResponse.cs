using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_SkillProficiencyResponse : UseCaseResponseMessage
    {
        public gen_skillproficiencyEntity _gen_SkillProficiency { get; }

        public IEnumerable<gen_skillproficiencyEntity> _gen_SkillProficiencyList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_SkillProficiencyResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_SkillProficiencyResponse(IEnumerable<gen_skillproficiencyEntity> gen_SkillProficiencyList, bool success = false, string message = null) : base(success, message)
        {
            _gen_SkillProficiencyList = gen_SkillProficiencyList;
        }
        
        public Gen_SkillProficiencyResponse(gen_skillproficiencyEntity gen_SkillProficiency, bool success = false, string message = null) : base(success, message)
        {
            _gen_SkillProficiency = gen_SkillProficiency;
        }

        public Gen_SkillProficiencyResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
