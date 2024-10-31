using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_EducationShiftResponse : UseCaseResponseMessage
    {
        public gen_educationshiftEntity _gen_EducationShift { get; }

        public IEnumerable<gen_educationshiftEntity> _gen_EducationShiftList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_EducationShiftResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_EducationShiftResponse(IEnumerable<gen_educationshiftEntity> gen_EducationShiftList, bool success = false, string message = null) : base(success, message)
        {
            _gen_EducationShiftList = gen_EducationShiftList;
        }
        
        public Gen_EducationShiftResponse(gen_educationshiftEntity gen_EducationShift, bool success = false, string message = null) : base(success, message)
        {
            _gen_EducationShift = gen_EducationShift;
        }

        public Gen_EducationShiftResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
