using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CertificateTypeResponse : UseCaseResponseMessage
    {
        public gen_certificatetypeEntity _gen_CertificateType { get; }

        public IEnumerable<gen_certificatetypeEntity> _gen_CertificateTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CertificateTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CertificateTypeResponse(IEnumerable<gen_certificatetypeEntity> gen_CertificateTypeList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CertificateTypeList = gen_CertificateTypeList;
        }
        
        public Gen_CertificateTypeResponse(gen_certificatetypeEntity gen_CertificateType, bool success = false, string message = null) : base(success, message)
        {
            _gen_CertificateType = gen_CertificateType;
        }

        public Gen_CertificateTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
