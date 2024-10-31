
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
    public sealed partial class reg_previousexperianceFacadeObjects
    {
		
       async Task<long> Ireg_previousexperianceFacadeObjects.AddExt(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().AddExt(reg_previousexperiance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_previousexperianceFacade.Addreg_previousexperiance"));
            }
		}
       
		async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceFacadeObjects.GetAllExt(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().GetAllExt(reg_previousexperiance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_previousexperianceEntity> Ireg_previousexperianceFacade.GetAllreg_previousexperiance"));
            }
		}
        
	}
}