using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_rolepermissionDataAccessObjects
    {
        Task<IList<owin_rolepermissionExtEntity>> GetRolesPermissionByParams(owin_rolepermissionExtEntity owin_rolepermission, CancellationToken cancellationToken);

    }
}
