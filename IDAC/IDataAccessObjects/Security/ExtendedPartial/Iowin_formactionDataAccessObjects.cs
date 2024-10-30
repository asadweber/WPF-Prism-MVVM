using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDAC.Core.IDataAccessObjects.Security
{
    public partial interface Iowin_formactionDataAccessObjects
    {
        Task<IList<Owin_ProcessGetFormActionistEntity>> GetFormActionByRole(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
        Task<long> AssignPermission(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
        Task<IList<Owin_ProcessGetFormActionistEntity>> GetFormActionListByMasterUserId(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
    }
}
