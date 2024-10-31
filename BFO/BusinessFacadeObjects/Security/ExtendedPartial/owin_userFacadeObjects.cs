


using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.Security
{
    public sealed partial class owin_userFacadeObjects : BaseFacade, Iowin_userFacadeObjects
    {

        async Task<owin_userEntity> Iowin_userFacadeObjects.GetSinglebyUsername(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createowin_userDataAccess().GetSinglebyUsername(owin_user, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userEntity Iowin_userFacade.GetSinglebyUsernameowin_user"));
            }
        }

    }
}