
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
    public sealed partial class gen_companiesFacadeObjects
    {
		
       async Task<long> Igen_companiesFacadeObjects.AddExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().AddExt(gen_companies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_companiesFacade.Addgen_companies"));
            }
		}
       
		async Task<IList<gen_companiesEntity>> Igen_companiesFacadeObjects.GetAllExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().GetAllExt(gen_companies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companiesEntity> Igen_companiesFacade.GetAllgen_companies"));
            }
		}

        async Task<IList<gen_companiesEntity>> Igen_companiesFacadeObjects.GAPgListViewExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_companiesDataAccess().GAPgListViewExt(gen_companies, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companiesEntity> Igen_companiesFacade.GAPgListViewExtgen_companies"));
            }
        }

    }
}