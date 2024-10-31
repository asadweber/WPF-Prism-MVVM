
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
    public sealed partial class gen_educationshiftFacadeObjects
    {
		
       async Task<long> Igen_educationshiftFacadeObjects.AddExt(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().AddExt(gen_educationshift, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationshiftFacade.Addgen_educationshift"));
            }
		}
       
		async Task<IList<gen_educationshiftEntity>> Igen_educationshiftFacadeObjects.GetAllExt(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().GetAllExt(gen_educationshift, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationshiftEntity> Igen_educationshiftFacade.GetAllgen_educationshift"));
            }
		}
        
	}
}