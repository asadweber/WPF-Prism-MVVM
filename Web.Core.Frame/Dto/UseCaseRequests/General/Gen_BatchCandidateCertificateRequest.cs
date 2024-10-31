using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_BatchCandidateCertificateRequest : IUseCaseRequest<Gen_BatchCandidateCertificateResponse>
    {
        public gen_batchcandidatecertificateEntity Objgen_batchcandidatecertificate { get; }

        public List<gen_batchcandidatecertificateEntity> Objgen_batchcandidatecertificateList { get; }

        public Gen_BatchCandidateCertificateRequest(gen_batchcandidatecertificateEntity objgen_batchcandidatecertificate)
        {
            Objgen_batchcandidatecertificate = objgen_batchcandidatecertificate;
        }

        public Gen_BatchCandidateCertificateRequest(List<gen_batchcandidatecertificateEntity> objgen_batchcandidatecertificateList)
        {
            Objgen_batchcandidatecertificateList = objgen_batchcandidatecertificateList;
        }
    }
}
