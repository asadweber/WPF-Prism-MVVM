
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
    public sealed partial class gen_generalhealthFacadeObjects
    {
		
       async Task<long> Igen_generalhealthFacadeObjects.AddExt(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().AddExt(gen_generalhealth, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_generalhealthFacade.Addgen_generalhealth"));
            }
		}
       
		async Task<IList<gen_generalhealthEntity>> Igen_generalhealthFacadeObjects.GetAllExt(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().GetAllExt(gen_generalhealth, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generalhealthEntity> Igen_generalhealthFacade.GetAllgen_generalhealth"));
            }
		}
        
	}
}