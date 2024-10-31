

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_nonkuwaitystatusFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_nonkuwaitystatusEntity>> GetAllExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
         
    }
}
