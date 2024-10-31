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
    public partial interface Itran_notificationbatchdetDataAccessObjects
    {

        Task<long> AddExt(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);

        Task<IList<tran_notificationbatchdetEntity>> GetAllExt(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);

        Task<IList<tran_notificationbatchdetEntity>> GetAllByBasicInfoRegistrationID(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
    }
}
