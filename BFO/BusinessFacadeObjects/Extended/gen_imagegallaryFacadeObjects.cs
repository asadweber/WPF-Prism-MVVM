
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
    public sealed partial class gen_imagegallaryFacadeObjects
    {
		
       async Task<long> Igen_imagegallaryFacadeObjects.AddExt(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().AddExt(gen_imagegallary, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_imagegallaryFacade.Addgen_imagegallary"));
            }
		}
       
		async Task<IList<gen_imagegallaryEntity>> Igen_imagegallaryFacadeObjects.GetAllExt(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().GetAllExt(gen_imagegallary, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallaryEntity> Igen_imagegallaryFacade.GetAllgen_imagegallary"));
            }
		}
        
	}
}