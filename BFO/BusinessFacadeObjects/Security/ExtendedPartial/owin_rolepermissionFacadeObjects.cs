using AppConfig.ConfigDAAC;
using BDO.Core.Base;
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
    public sealed partial class owin_rolepermissionFacadeObjects 
    {
		
		async Task<IList<owin_rolepermissionExtEntity>> Iowin_rolepermissionFacadeObjects.GetRolesPermissionByParams(owin_rolepermissionExtEntity owin_rolepermission, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().GetRolesPermissionByParams(owin_rolepermission, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionExtEntity> Iowin_rolepermissionFacade.GetRolesPermissionByParams"));
            }
		}
	}
}