

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_religionFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_religionEntity gen_religion, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_religionEntity>> GetAllExt(gen_religionEntity gen_religion, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_religionEntity>> GetReligionDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken);

    }
}
