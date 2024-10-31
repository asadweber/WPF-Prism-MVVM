

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_imagegallarycategoryFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_imagegallarycategoryEntity>> GetAllExt(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
         
    }
}
