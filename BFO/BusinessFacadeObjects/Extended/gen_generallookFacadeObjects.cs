
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
    public sealed partial class gen_generallookFacadeObjects
    {
		
       async Task<long> Igen_generallookFacadeObjects.AddExt(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().AddExt(gen_generallook, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_generallookFacade.Addgen_generallook"));
            }
		}
       
		async Task<IList<gen_generallookEntity>> Igen_generallookFacadeObjects.GetAllExt(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().GetAllExt(gen_generallook, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generallookEntity> Igen_generallookFacade.GetAllgen_generallook"));
            }
		}
        
	}
}