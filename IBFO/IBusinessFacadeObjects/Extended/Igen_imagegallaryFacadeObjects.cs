

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_imagegallaryFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_imagegallaryEntity>> GetAllExt(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
         
    }
}
