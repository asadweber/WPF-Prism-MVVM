

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_companiesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_companiesEntity>> GetAllExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_companiesEntity>> GAPgListViewExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
    }
}
