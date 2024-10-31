

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_professiongroupFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_professiongroupEntity>> GetAllExt(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
         
    }
}
