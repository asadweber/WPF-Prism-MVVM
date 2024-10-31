

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_countryclassFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_countryclassEntity>> GetAllExt(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
        [OperationContract]
        Task<IList<gen_countryclassEntity>> GetCountryClassDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);

    }
}
