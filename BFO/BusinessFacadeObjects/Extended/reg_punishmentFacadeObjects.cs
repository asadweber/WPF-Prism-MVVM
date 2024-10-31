
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
    public sealed partial class reg_punishmentFacadeObjects
    {
		
       async Task<long> Ireg_punishmentFacadeObjects.AddExt(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().AddExt(reg_punishment, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_punishmentFacade.Addreg_punishment"));
            }
		}
       
		async Task<IList<reg_punishmentEntity>> Ireg_punishmentFacadeObjects.GetAllExt(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().GetAllExt(reg_punishment, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_punishmentEntity> Ireg_punishmentFacade.GetAllreg_punishment"));
            }
		}
        
	}
}