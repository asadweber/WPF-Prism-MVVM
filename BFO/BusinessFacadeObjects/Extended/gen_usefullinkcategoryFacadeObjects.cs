
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
    public sealed partial class gen_usefullinkcategoryFacadeObjects
    {
		
       async Task<long> Igen_usefullinkcategoryFacadeObjects.AddExt(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().AddExt(gen_usefullinkcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_usefullinkcategoryFacade.Addgen_usefullinkcategory"));
            }
		}
       
		async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryFacadeObjects.GetAllExt(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().GetAllExt(gen_usefullinkcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkcategoryEntity> Igen_usefullinkcategoryFacade.GetAllgen_usefullinkcategory"));
            }
		}
        
	}
}