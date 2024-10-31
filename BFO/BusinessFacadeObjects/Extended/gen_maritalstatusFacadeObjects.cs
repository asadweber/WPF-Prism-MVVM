
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
    public sealed partial class gen_maritalstatusFacadeObjects
    {
		
       async Task<long> Igen_maritalstatusFacadeObjects.AddExt(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().AddExt(gen_maritalstatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_maritalstatusFacade.Addgen_maritalstatus"));
            }
		}
       
		async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusFacadeObjects.GetAllExt(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().GetAllExt(gen_maritalstatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GetAllgen_maritalstatus"));
            }
		}

        async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusFacadeObjects.GetMaritalStatusDataForDropDown(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_maritalstatusDataAccess().GetMaritalStatusDataForDropDown(gen_maritalstatus, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GetMaritalStatusDataForDropDown"));
            }
        }
    }
}