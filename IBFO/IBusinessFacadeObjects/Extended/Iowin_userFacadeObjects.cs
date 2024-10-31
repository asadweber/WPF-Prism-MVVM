

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    public partial interface Iowin_userFacadeObjects : IDisposable
    {
        [OperationContract]
        Task<owin_userEntity> GetSinglebyUsername(owin_userEntity owin_user, CancellationToken cancellationToken);
    }
}
