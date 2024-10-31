

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_phasesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_phasesEntity>> GetAllExt(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
         
    }
}
