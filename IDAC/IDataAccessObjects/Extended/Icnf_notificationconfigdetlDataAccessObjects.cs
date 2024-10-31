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
    public partial interface Icnf_notificationconfigdetlDataAccessObjects
    {
        Task<long> AddExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);

        Task<IList<cnf_notificationconfigdetlEntity>> GetAllExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);

        Task<IList<cnf_notificationconfigdetlEntity>> GAPgListViewExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);

        Task<cnf_notificationconfigdetlEntity> GetSingleExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
    }
}