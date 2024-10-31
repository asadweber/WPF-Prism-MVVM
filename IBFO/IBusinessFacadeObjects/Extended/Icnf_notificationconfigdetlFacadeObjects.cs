

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_notificationconfigdetlFacadeObjects
    {
        [OperationContract]
        Task<long> AddExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<cnf_notificationconfigdetlEntity>> GetAllExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<cnf_notificationconfigdetlEntity>> GAPgListViewExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);

        [OperationContract]
        Task<cnf_notificationconfigdetlEntity> GetSingleExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
    }
}
