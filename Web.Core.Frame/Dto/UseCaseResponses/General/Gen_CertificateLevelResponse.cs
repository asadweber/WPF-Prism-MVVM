using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CertificateLevelResponse : UseCaseResponseMessage
    {
        public gen_certificatelevelEntity _gen_CertificateLevel { get; }

        public IEnumerable<gen_certificatelevelEntity> _gen_CertificateLevelList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CertificateLevelResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CertificateLevelResponse(IEnumerable<gen_certificatelevelEntity> gen_CertificateLevelList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CertificateLevelList = gen_CertificateLevelList;
        }
        
        public Gen_CertificateLevelResponse(gen_certificatelevelEntity gen_CertificateLevel, bool success = false, string message = null) : base(success, message)
        {
            _gen_CertificateLevel = gen_CertificateLevel;
        }

        public Gen_CertificateLevelResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
