

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Itran_notificationbatchdetFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<tran_notificationbatchdetEntity>> GetAllExt(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<tran_notificationbatchdetEntity>> GetAllByBasicInfoRegistrationID(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);

    }
}
