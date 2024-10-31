

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_studentmenuskipFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<cnf_studentmenuskipEntity>> GetAllExt(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
         
    }
}
