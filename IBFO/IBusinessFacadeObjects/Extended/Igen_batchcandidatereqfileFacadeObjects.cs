

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_batchcandidatereqfileFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_batchcandidatereqfileEntity>> GetAllExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchcandidatereqfileEntity>> GAPgListViewExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_batchcandidatereqfileEntity> GetSingleExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
    }
}
