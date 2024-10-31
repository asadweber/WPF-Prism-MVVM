

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_batchcandidatetypemapFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_batchcandidatetypemapEntity>> GetAllExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchcandidatetypemapEntity>> GAPgListViewExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetDataForDropDownExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_batchcandidatetypemapEntity> GetSingleByBatchCandidateTypeID(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
    }
}
