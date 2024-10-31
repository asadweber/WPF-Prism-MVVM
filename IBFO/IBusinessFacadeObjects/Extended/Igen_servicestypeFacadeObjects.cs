

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_servicestypeFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_servicestypeEntity>> GetAllExt(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
         
    }
}
