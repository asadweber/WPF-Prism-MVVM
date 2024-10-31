

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_notificationtempletFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<cnf_notificationtempletEntity>> GetAllExt(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<cnf_notificationtempletEntity>> GetNotificationTemplateWithMsgDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
    }
}
