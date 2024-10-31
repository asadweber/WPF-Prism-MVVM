

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_generalhealthFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_generalhealthEntity>> GetAllExt(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
         
    }
}
