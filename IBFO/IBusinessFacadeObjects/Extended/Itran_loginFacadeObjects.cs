

using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.Base;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Itran_loginFacadeObjects
    { 
		[OperationContract]
        Task<IList<RefreshToken>> GetAllTokenByUser(tran_loginEntity tran_login, CancellationToken cancellationToken);
		
		
    }
}
