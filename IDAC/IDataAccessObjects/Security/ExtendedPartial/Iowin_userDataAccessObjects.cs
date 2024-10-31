using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userDataAccessObjects
    {
        Task<owin_userEntity> GetSinglebyUsername(owin_userEntity owin_user, CancellationToken cancellationToken);
    }
}
