

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_punishmentFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_punishmentEntity>> GetAllExt(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
         
    }
}
