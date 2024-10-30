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
    public sealed partial class owin_roleFacadeObjects 
    {
		
		async Task<IList<owin_roleEntity>> Iowin_roleFacadeObjects.GetByUsrID(owin_userEntity owin_user, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_roleDataAccess().GetByUsrID(owin_user, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_roleEntity> Iowin_roleFacade.GetByUsrID"));
            }
		}
		
	}
}