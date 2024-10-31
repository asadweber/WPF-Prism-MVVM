

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Istp_organizationFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<stp_organizationEntity>> GetAllExt(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
         
    }
}
