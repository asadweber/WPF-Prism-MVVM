using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CertificateResponse : UseCaseResponseMessage
    {
        public gen_certificateEntity _gen_Certificate { get; }

        public IEnumerable<gen_certificateEntity> _gen_CertificateList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CertificateResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CertificateResponse(IEnumerable<gen_certificateEntity> gen_CertificateList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CertificateList = gen_CertificateList;
        }
        
        public Gen_CertificateResponse(gen_certificateEntity gen_Certificate, bool success = false, string message = null) : base(success, message)
        {
            _gen_Certificate = gen_Certificate;
        }

        public Gen_CertificateResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
