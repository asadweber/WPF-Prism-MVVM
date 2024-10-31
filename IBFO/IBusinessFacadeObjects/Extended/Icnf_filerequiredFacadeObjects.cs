

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_filerequiredFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<cnf_filerequiredEntity>> GetAllExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<cnf_filerequiredEntity>> GAPgListViewExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
    }
}
