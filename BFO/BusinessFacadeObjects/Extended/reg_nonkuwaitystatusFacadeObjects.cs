
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace BFO.Core.BusinessFacadeObjects.General
{
    public sealed partial class reg_nonkuwaitystatusFacadeObjects
    {
		
       async Task<long> Ireg_nonkuwaitystatusFacadeObjects.AddExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().AddExt(reg_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_nonkuwaitystatusFacade.Addreg_nonkuwaitystatus"));
            }
		}
       
		async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusFacadeObjects.GetAllExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().GetAllExt(reg_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_nonkuwaitystatusEntity> Ireg_nonkuwaitystatusFacade.GetAllreg_nonkuwaitystatus"));
            }
		}
        
	}
}