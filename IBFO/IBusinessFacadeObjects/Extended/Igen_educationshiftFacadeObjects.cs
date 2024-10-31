

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_educationshiftFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_educationshiftEntity>> GetAllExt(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
         
    }
}
