
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
    public sealed partial class gen_countryFacadeObjects
    {
		
       async Task<long> Igen_countryFacadeObjects.AddExt(gen_countryEntity gen_country, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryDataAccess().AddExt(gen_country, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_countryFacade.Addgen_country"));
            }
		}
       
		async Task<IList<gen_countryEntity>> Igen_countryFacadeObjects.GetAllExt(gen_countryEntity gen_country, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryDataAccess().GetAllExt(gen_country, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryEntity> Igen_countryFacade.GetAllgen_country"));
            }
		}

        async Task<IList<gen_countryEntity>> Igen_countryFacadeObjects.GetCountryDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_countryDataAccess().GetCountryDropDown(gen_country, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryEntity> Igen_countryFacade.GetAllgen_country"));
            }
        }
        async Task<gen_countryEntity> Igen_countryFacadeObjects.GetSingleByCountryId(gen_countryEntity gen_country, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_countryDataAccess().GetSingleByCountryId(gen_country, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_countryEntity Igen_countryFacade.GetSinglegen_country"));
            }
        }
        async Task<IList<gen_dropdownEntity>> Igen_countryFacadeObjects.GetNationalityForDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_countryDataAccess().GetNationalityForDropDown(gen_country, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryEntity> Igen_countryFacade.GetNationalityForDropDown"));
            }
        }



    }
}