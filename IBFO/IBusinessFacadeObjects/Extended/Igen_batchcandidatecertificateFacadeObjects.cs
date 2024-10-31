

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_batchcandidatecertificateFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_batchcandidatecertificateEntity>> GetAllExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_batchcandidatecertificateEntity> GetSingleExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchcandidatecertificateEntity>> GAPgListViewExt(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);

    }
}
