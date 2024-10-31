

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_hobbiesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_hobbiesEntity>> GetAllExt(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
         
    }
}
