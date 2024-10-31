using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;



namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Itran_notificationbatchDataAccessObjects
    {

        Task<long> AddExt(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);

        Task<IList<tran_notificationbatchEntity>> GetAllExt(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
        
        Task<long> SaveNotificationBatchWithProfileList(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);

    }
}
