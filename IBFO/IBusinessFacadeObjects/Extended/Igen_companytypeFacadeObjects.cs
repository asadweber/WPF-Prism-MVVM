

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_companytypeFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_companytypeEntity>> GetAllExt(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
         
    }
}
