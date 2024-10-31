
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
    public sealed partial class gen_servicestypeFacadeObjects
    {
		
       async Task<long> Igen_servicestypeFacadeObjects.AddExt(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().AddExt(gen_servicestype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicestypeFacade.Addgen_servicestype"));
            }
		}
       
		async Task<IList<gen_servicestypeEntity>> Igen_servicestypeFacadeObjects.GetAllExt(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().GetAllExt(gen_servicestype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestypeEntity> Igen_servicestypeFacade.GetAllgen_servicestype"));
            }
		}
        
	}
}