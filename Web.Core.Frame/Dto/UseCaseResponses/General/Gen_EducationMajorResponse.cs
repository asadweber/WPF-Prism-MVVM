using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_EducationMajorResponse : UseCaseResponseMessage
    {
        public gen_educationmajorEntity _gen_EducationMajor { get; }

        public IEnumerable<gen_educationmajorEntity> _gen_EducationMajorList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_EducationMajorResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_EducationMajorResponse(IEnumerable<gen_educationmajorEntity> gen_EducationMajorList, bool success = false, string message = null) : base(success, message)
        {
            _gen_EducationMajorList = gen_EducationMajorList;
        }
        
        public Gen_EducationMajorResponse(gen_educationmajorEntity gen_EducationMajor, bool success = false, string message = null) : base(success, message)
        {
            _gen_EducationMajor = gen_EducationMajor;
        }

        public Gen_EducationMajorResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
