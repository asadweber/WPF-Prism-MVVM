

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_datacheckedFacadeObjects : IDisposable
    { 
        
        [OperationContract]
        Task<reg_datacheckedEntity> GetRegDataCheckedByBasicinfoRegistrationID(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
    
    }
}
