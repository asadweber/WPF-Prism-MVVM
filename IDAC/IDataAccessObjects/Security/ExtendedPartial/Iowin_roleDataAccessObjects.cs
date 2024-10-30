using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_roleDataAccessObjects
    {

        Task<IList<owin_roleEntity>> GetByUsrID(owin_userEntity owin_user, CancellationToken cancellationToken);


    }
}
