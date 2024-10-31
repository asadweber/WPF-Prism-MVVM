
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
    public sealed partial class gen_skillproficiencyFacadeObjects
    {
		
       async Task<long> Igen_skillproficiencyFacadeObjects.AddExt(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().AddExt(gen_skillproficiency, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_skillproficiencyFacade.Addgen_skillproficiency"));
            }
		}
       
		async Task<IList<gen_skillproficiencyEntity>> Igen_skillproficiencyFacadeObjects.GetAllExt(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().GetAllExt(gen_skillproficiency, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_skillproficiencyEntity> Igen_skillproficiencyFacade.GetAllgen_skillproficiency"));
            }
		}
        
	}
}