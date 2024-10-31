

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Istp_organizationentityFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<stp_organizationentityEntity>> GetAllExt(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
         
    }
}
