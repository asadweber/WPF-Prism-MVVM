using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_EducationGradeResponse : UseCaseResponseMessage
    {
        public kns_gen_educationgradeEntity _kns_GenEducationGrade { get; }

        public IEnumerable<kns_gen_educationgradeEntity> _kns_GenEducationGradeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_EducationGradeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_EducationGradeResponse(IEnumerable<kns_gen_educationgradeEntity> kns_GenEducationGradeList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenEducationGradeList = kns_GenEducationGradeList;
        }
        
        public Kns_Gen_EducationGradeResponse(kns_gen_educationgradeEntity kns_GenEducationGrade, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenEducationGrade = kns_GenEducationGrade;
        }

        public Kns_Gen_EducationGradeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
