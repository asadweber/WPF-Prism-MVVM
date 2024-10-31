
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
    public sealed partial class gen_civilworkplacesFacadeObjects
    {
		
       async Task<long> Igen_civilworkplacesFacadeObjects.AddExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().AddExt(gen_civilworkplaces, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_civilworkplacesFacade.Addgen_civilworkplaces"));
            }
		}
       
		async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesFacadeObjects.GetAllExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().GetAllExt(gen_civilworkplaces, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_civilworkplacesEntity> Igen_civilworkplacesFacade.GetAllgen_civilworkplaces"));
            }
		}

        async Task<gen_civilworkplacesEntity> Igen_civilworkplacesFacadeObjects.GetSingleExt(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_civilworkplacesDataAccess().GetSingleExt(gen_civilworkplaces, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_civilworkplacesEntity Igen_civilworkplacesFacade.GetSingleExtgen_civilworkplaces"));
            }
        }

    }
}