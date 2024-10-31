
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
    public sealed partial class gen_countrycityFacadeObjects
    {
		
       async Task<long> Igen_countrycityFacadeObjects.AddExt(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().AddExt(gen_countrycity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_countrycityFacade.Addgen_countrycity"));
            }
		}
       
		async Task<IList<gen_countrycityEntity>> Igen_countrycityFacadeObjects.GetAllExt(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().GetAllExt(gen_countrycity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countrycityEntity> Igen_countrycityFacade.GetAllgen_countrycity"));
            }
		}

        async Task<IList<gen_countrycityEntity>> Igen_countrycityFacadeObjects.GetGovernateDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_countrycityDataAccess().GetGovernateDropDown(gen_countrycity, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countrycityEntity> Igen_countrycityFacade.GetGovernateDropDown"));
            }
        }
        async Task<bool> Igen_countrycityFacadeObjects.CheckHasGovernarate(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_countrycityDataAccess().CheckHasGovernarate(gen_countrycity, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countrycityEntity> Igen_countrycityFacade.GetGovernateDropDown"));
            }
        }


    }
}