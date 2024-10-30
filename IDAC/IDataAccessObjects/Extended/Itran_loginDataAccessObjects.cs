using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_loginDataAccessObjects
    {
		 
		Task<IList<tran_loginEntity>> GetAllTokenByUser(tran_loginEntity tran_login, CancellationToken cancellationToken);
		
        
		
    }
}
