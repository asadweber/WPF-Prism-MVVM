

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_serviceinfoFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_serviceinfoEntity>> GetAllExt(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
         
    }
}
