

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_statusFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_statusEntity gen_status, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_statusEntity>> GetAllExt(gen_statusEntity gen_status, CancellationToken cancellationToken);
         
    }
}
