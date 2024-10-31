

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_countrycityFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_countrycityEntity>> GetAllExt(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
        [OperationContract]
        Task<IList<gen_countrycityEntity>> GetGovernateDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);

        [OperationContract]
        Task<bool> CheckHasGovernarate(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);


    }
}
