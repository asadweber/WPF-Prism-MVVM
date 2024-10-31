
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
    public sealed partial class gen_serviceinfoFacadeObjects
    {
		
       async Task<long> Igen_serviceinfoFacadeObjects.AddExt(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().AddExt(gen_serviceinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_serviceinfoFacade.Addgen_serviceinfo"));
            }
		}
       
		async Task<IList<gen_serviceinfoEntity>> Igen_serviceinfoFacadeObjects.GetAllExt(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().GetAllExt(gen_serviceinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_serviceinfoEntity> Igen_serviceinfoFacade.GetAllgen_serviceinfo"));
            }
		}
        
	}
}