

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_genderFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_genderEntity gen_gender, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_genderEntity>> GetAllExt(gen_genderEntity gen_gender, CancellationToken cancellationToken);
         
    }
}
