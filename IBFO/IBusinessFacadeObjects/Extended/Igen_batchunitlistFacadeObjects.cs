

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_batchunitlistFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_batchunitlistEntity>> GetAllExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_batchunitlistEntity>> GAPgListViewExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
    }
}
