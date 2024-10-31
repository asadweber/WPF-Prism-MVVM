

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_generallookFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_generallookEntity>> GetAllExt(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
         
    }
}
