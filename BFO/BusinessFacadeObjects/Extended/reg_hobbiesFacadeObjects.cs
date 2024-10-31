
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
    public sealed partial class reg_hobbiesFacadeObjects
    {
		
       async Task<long> Ireg_hobbiesFacadeObjects.AddExt(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().AddExt(reg_hobbies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_hobbiesFacade.Addreg_hobbies"));
            }
		}
       
		async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesFacadeObjects.GetAllExt(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().GetAllExt(reg_hobbies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_hobbiesEntity> Ireg_hobbiesFacade.GetAllreg_hobbies"));
            }
		}
        
	}
}