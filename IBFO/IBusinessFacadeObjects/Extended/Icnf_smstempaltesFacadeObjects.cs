

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_smstempaltesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<cnf_smstempaltesEntity>> GetAllExt(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
         
    }
}
