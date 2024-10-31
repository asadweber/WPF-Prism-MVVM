using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;



namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Igen_batchDataAccessObjects
    {
        Task<long> AddExt(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        Task<IList<gen_batchEntity>> GetAllExt(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        Task<IList<gen_batchEntity>> GetActiveBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        Task<IList<gen_batchEntity>> GetActiveBatchDropDownForReview(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        Task<IList<gen_batchEntity>> GetAllBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        Task<gen_batchEntity> GetBatchById(gen_batchEntity gen_batch, CancellationToken cancellationToken);

        Task<IList<gen_dropdownEntity>> GetMilitaryTypeWiseBatchForDropDown(gen_batchEntity gen_batch, CancellationToken cancellationToken);
    }
}
