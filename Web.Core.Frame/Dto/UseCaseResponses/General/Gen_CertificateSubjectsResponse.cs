using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CertificateSubjectsResponse : UseCaseResponseMessage
    {
        public gen_certificatesubjectsEntity _gen_CertificateSubjects { get; }

        public IEnumerable<gen_certificatesubjectsEntity> _gen_CertificateSubjectsList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CertificateSubjectsResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CertificateSubjectsResponse(IEnumerable<gen_certificatesubjectsEntity> gen_CertificateSubjectsList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CertificateSubjectsList = gen_CertificateSubjectsList;
        }
        
        public Gen_CertificateSubjectsResponse(gen_certificatesubjectsEntity gen_CertificateSubjects, bool success = false, string message = null) : base(success, message)
        {
            _gen_CertificateSubjects = gen_CertificateSubjects;
        }

        public Gen_CertificateSubjectsResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
