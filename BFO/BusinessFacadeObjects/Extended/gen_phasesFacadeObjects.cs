
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
    public sealed partial class gen_phasesFacadeObjects
    {
		
       async Task<long> Igen_phasesFacadeObjects.AddExt(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().AddExt(gen_phases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_phasesFacade.Addgen_phases"));
            }
		}
       
		async Task<IList<gen_phasesEntity>> Igen_phasesFacadeObjects.GetAllExt(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().GetAllExt(gen_phases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_phasesEntity> Igen_phasesFacade.GetAllgen_phases"));
            }
		}
        
	}
}