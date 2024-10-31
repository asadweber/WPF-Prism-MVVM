using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_EducationGradeResponse : UseCaseResponseMessage
    {
        public gen_educationgradeEntity _gen_EducationGrade { get; }

        public IEnumerable<gen_educationgradeEntity> _gen_EducationGradeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_EducationGradeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_EducationGradeResponse(IEnumerable<gen_educationgradeEntity> gen_EducationGradeList, bool success = false, string message = null) : base(success, message)
        {
            _gen_EducationGradeList = gen_EducationGradeList;
        }
        
        public Gen_EducationGradeResponse(gen_educationgradeEntity gen_EducationGrade, bool success = false, string message = null) : base(success, message)
        {
            _gen_EducationGrade = gen_EducationGrade;
        }

        public Gen_EducationGradeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
