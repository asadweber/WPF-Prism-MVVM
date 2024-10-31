

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Itran_notificationbatchFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<tran_notificationbatchEntity>> GetAllExt(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveNotificationBatchWithProfileList(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
    }
}
