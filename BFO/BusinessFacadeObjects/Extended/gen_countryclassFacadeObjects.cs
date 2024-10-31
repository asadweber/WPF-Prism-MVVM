
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
    public sealed partial class gen_countryclassFacadeObjects
    {
		
       async Task<long> Igen_countryclassFacadeObjects.AddExt(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().AddExt(gen_countryclass, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_countryclassFacade.Addgen_countryclass"));
            }
		}
       
		async Task<IList<gen_countryclassEntity>> Igen_countryclassFacadeObjects.GetAllExt(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().GetAllExt(gen_countryclass, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryclassEntity> Igen_countryclassFacade.GetAllgen_countryclass"));
            }
		}


        async Task<IList<gen_countryclassEntity>> Igen_countryclassFacadeObjects.GetCountryClassDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_countryclassDataAccess().GetCountryClassDropDown(gen_countryclass, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryclassEntity> Igen_countryclassFacade.GetAllByPagesgen_countryclass"));
            }
        }

    }
}