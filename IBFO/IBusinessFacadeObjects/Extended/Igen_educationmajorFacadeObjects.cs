

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_educationmajorFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_educationmajorEntity>> GetAllExt(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
         
    }
}
