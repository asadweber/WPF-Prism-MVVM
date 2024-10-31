

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_rankFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_rankEntity gen_rank, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_rankEntity>> GetAllExt(gen_rankEntity gen_rank, CancellationToken cancellationToken);
         
    }
}
