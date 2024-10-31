

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_fileconfignameFacadeObjects : IDisposable
    {
        [OperationContract]
        Task<IList<cnf_fileconfignameEntity>> GetAllByBatchID(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
    }
}
