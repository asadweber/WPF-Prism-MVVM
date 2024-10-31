
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
    public sealed partial class gen_imagegallarycategoryFacadeObjects
    {
		
       async Task<long> Igen_imagegallarycategoryFacadeObjects.AddExt(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().AddExt(gen_imagegallarycategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_imagegallarycategoryFacade.Addgen_imagegallarycategory"));
            }
		}
       
		async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryFacadeObjects.GetAllExt(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().GetAllExt(gen_imagegallarycategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallarycategoryEntity> Igen_imagegallarycategoryFacade.GetAllgen_imagegallarycategory"));
            }
		}
        
	}
}