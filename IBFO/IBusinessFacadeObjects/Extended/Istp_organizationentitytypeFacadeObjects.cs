

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Istp_organizationentitytypeFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<stp_organizationentitytypeEntity>> GetAllExt(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
         
    }
}
