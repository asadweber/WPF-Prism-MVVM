

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_civilworkplacesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_civilworkplacesEntity>> GetAllExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_civilworkplacesEntity> GetSingleExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
    }
}
