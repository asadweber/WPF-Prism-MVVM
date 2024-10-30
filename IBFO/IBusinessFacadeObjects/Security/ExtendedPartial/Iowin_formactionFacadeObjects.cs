using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;

namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    public partial interface Iowin_formactionFacadeObjects
    {
        [OperationContract]
        Task<IList<Owin_ProcessGetFormActionistEntity>> GetFormActionByRole(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> AssignPermission(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<Owin_ProcessGetFormActionistEntity>> GetFormActionListByMasterUserId(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
    }
}
