

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_bloodgroupFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_bloodgroupEntity>> GetAllExt(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<IList<gen_bloodgroupEntity>> GetBloodGroupDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);

    }
}
