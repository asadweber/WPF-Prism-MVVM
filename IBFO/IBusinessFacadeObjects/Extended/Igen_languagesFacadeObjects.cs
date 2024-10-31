

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_languagesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_languagesEntity>> GetAllExt(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
         
    }
}
