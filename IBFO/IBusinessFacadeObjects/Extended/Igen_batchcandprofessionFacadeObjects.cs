

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_batchcandprofessionFacadeObjects
    {
        [OperationContract]
        Task<long> AddExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchcandprofessionEntity>> GetAllExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_batchcandprofessionEntity> GetSingleExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchcandprofessionEntity>> GAPgListViewExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_batchcandprofessionEntity> GetSingleByBatchCandidateTypeMapProfessionID(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
    }
}
