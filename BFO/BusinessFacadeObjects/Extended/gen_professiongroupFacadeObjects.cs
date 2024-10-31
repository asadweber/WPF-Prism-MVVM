
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
    public sealed partial class gen_professiongroupFacadeObjects
    {
		
       async Task<long> Igen_professiongroupFacadeObjects.AddExt(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().AddExt(gen_professiongroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_professiongroupFacade.Addgen_professiongroup"));
            }
		}
       
		async Task<IList<gen_professiongroupEntity>> Igen_professiongroupFacadeObjects.GetAllExt(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().GetAllExt(gen_professiongroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professiongroupEntity> Igen_professiongroupFacade.GetAllgen_professiongroup"));
            }
		}
        
	}
}