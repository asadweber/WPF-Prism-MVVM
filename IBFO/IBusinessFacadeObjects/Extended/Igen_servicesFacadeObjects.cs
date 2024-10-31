

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_servicesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_servicesEntity gen_services, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_servicesEntity>> GetAllExt(gen_servicesEntity gen_services, CancellationToken cancellationToken);
         
    }
}
