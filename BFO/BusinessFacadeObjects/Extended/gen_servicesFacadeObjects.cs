
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
    public sealed partial class gen_servicesFacadeObjects
    {
		
       async Task<long> Igen_servicesFacadeObjects.AddExt(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().AddExt(gen_services, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicesFacade.Addgen_services"));
            }
		}
       
		async Task<IList<gen_servicesEntity>> Igen_servicesFacadeObjects.GetAllExt(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().GetAllExt(gen_services, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicesEntity> Igen_servicesFacade.GetAllgen_services"));
            }
		}
        
	}
}