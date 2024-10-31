

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_relativesworkinginmodFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_relativesworkinginmodEntity>> GetAllExt(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
         
    }
}
