

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_usefullinkcategoryFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_usefullinkcategoryEntity>> GetAllExt(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
         
    }
}
