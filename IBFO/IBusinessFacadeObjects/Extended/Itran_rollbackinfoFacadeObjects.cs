

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Itran_rollbackinfoFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<tran_rollbackinfoEntity>> GetAllExt(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
         
    }
}
