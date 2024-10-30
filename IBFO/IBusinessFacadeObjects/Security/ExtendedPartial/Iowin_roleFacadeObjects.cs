

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    public partial interface Iowin_roleFacadeObjects 
    { 
		
		[OperationContract]
        Task<IList<owin_roleEntity>> GetByUsrID(owin_userEntity owin_user, CancellationToken cancellationToken);
		
		
		
        
    }
}
