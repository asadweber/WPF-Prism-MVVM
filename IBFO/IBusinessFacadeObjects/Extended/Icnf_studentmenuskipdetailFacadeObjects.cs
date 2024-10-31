

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_studentmenuskipdetailFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<cnf_studentmenuskipdetailEntity>> GetAllExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
         
    }
}
