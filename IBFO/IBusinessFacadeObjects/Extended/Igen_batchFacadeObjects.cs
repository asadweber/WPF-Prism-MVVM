

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_batchFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_batchEntity gen_batch, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_batchEntity>> GetAllExt(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchEntity>> GetActiveBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchEntity>> GetActiveBatchDropDownForReview(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchEntity>> GetAllBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_batchEntity> GetBatchById(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetMilitaryTypeWiseBatchForDropDown(gen_batchEntity gen_batch, CancellationToken cancellationToken);
    }
}
