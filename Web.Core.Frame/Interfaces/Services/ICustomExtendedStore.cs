using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.HRDomainModel;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces
{
    interface ICustomExtendedStore<TUser> : IDisposable where TUser : class
    {
        Task<TUser> createUserProfileAsync(GetMilShortInfoByBasicMilEntity objUserHRProfile, CancellationToken cancellationToken);
    }
}
