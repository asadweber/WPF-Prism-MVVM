using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_CertificateResponse : UseCaseResponseMessage
    {
        public kns_gen_certificateEntity _kns_GenCertificate { get; }

        public IEnumerable<kns_gen_certificateEntity> _kns_GenCertificateList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_CertificateResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_CertificateResponse(IEnumerable<kns_gen_certificateEntity> kns_GenCertificateList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenCertificateList = kns_GenCertificateList;
        }
        
        public Kns_Gen_CertificateResponse(kns_gen_certificateEntity kns_GenCertificate, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenCertificate = kns_GenCertificate;
        }

        public Kns_Gen_CertificateResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
