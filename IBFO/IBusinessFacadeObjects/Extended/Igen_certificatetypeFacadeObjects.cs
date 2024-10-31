

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_certificatetypeFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_certificatetypeEntity>> GetAllExt(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
         
    }
}
