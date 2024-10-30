

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    public partial interface Iowin_rolepermissionFacadeObjects
    { 
		
		
		[OperationContract]
        Task<IList<owin_rolepermissionExtEntity>> GetRolesPermissionByParams(owin_rolepermissionExtEntity owin_rolepermission, CancellationToken cancellationToken);
     
		
    }
}
