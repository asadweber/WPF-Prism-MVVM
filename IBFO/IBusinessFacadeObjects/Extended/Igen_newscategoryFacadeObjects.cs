

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_newscategoryFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_newscategoryEntity>> GetAllExt(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
         
    }
}
