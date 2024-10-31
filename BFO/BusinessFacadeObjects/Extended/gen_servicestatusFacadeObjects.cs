
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
    public sealed partial class gen_servicestatusFacadeObjects
    {
		
       async Task<long> Igen_servicestatusFacadeObjects.AddExt(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestatusDataAccess().AddExt(gen_servicestatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicestatusFacade.Addgen_servicestatus"));
            }
		}
       
		async Task<IList<gen_servicestatusEntity>> Igen_servicestatusFacadeObjects.GetAllExt(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestatusDataAccess().GetAllExt(gen_servicestatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestatusEntity> Igen_servicestatusFacade.GetAllgen_servicestatus"));
            }
		}
        
	}
}