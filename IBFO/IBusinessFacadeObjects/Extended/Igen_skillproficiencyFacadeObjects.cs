

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_skillproficiencyFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_skillproficiencyEntity>> GetAllExt(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
         
    }
}
