using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_BatchCandidateCertificateResponse : UseCaseResponseMessage
    {
        public gen_batchcandidatecertificateEntity _gen_BatchCandidateCertificate { get; }

        public IEnumerable<gen_batchcandidatecertificateEntity> _gen_BatchCandidateCertificateList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_BatchCandidateCertificateResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_BatchCandidateCertificateResponse(IEnumerable<gen_batchcandidatecertificateEntity> gen_BatchCandidateCertificateList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandidateCertificateList = gen_BatchCandidateCertificateList;
        }
        
        public Gen_BatchCandidateCertificateResponse(gen_batchcandidatecertificateEntity gen_BatchCandidateCertificate, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandidateCertificate = gen_BatchCandidateCertificate;
        }

        public Gen_BatchCandidateCertificateResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
