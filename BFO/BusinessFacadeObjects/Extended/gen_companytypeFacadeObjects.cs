
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
    public sealed partial class gen_companytypeFacadeObjects
    {
		
       async Task<long> Igen_companytypeFacadeObjects.AddExt(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().AddExt(gen_companytype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_companytypeFacade.Addgen_companytype"));
            }
		}
       
		async Task<IList<gen_companytypeEntity>> Igen_companytypeFacadeObjects.GetAllExt(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().GetAllExt(gen_companytype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companytypeEntity> Igen_companytypeFacade.GetAllgen_companytype"));
            }
		}
        
	}
}