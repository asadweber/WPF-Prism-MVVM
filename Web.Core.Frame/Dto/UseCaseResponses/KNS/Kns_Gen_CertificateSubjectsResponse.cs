using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_CertificateSubjectsResponse : UseCaseResponseMessage
    {
        public kns_gen_certificatesubjectsEntity _kns_GenCertificateSubjects { get; }

        public IEnumerable<kns_gen_certificatesubjectsEntity> _kns_GenCertificateSubjectsList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_CertificateSubjectsResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_CertificateSubjectsResponse(IEnumerable<kns_gen_certificatesubjectsEntity> kns_GenCertificateSubjectsList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenCertificateSubjectsList = kns_GenCertificateSubjectsList;
        }
        
        public Kns_Gen_CertificateSubjectsResponse(kns_gen_certificatesubjectsEntity kns_GenCertificateSubjects, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenCertificateSubjects = kns_GenCertificateSubjects;
        }

        public Kns_Gen_CertificateSubjectsResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
