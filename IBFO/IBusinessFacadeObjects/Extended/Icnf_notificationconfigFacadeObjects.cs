

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_notificationconfigFacadeObjects
    {
        [OperationContract]
        Task<long> AddExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<cnf_notificationconfigEntity>> GetAllExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<cnf_notificationconfigEntity>> GAPgListViewExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetDataForDropDownExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
    }
}