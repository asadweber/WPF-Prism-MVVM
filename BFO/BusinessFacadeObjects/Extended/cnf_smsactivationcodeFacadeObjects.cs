
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
    public sealed partial class cnf_smsactivationcodeFacadeObjects
    {
		
       async Task<long> Icnf_smsactivationcodeFacadeObjects.AddExt(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().AddExt(cnf_smsactivationcode, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationcodeFacade.Addcnf_smsactivationcode"));
            }
		}
       
		async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeFacadeObjects.GetAllExt(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().GetAllExt(cnf_smsactivationcode, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeFacade.GetAllcnf_smsactivationcode"));
            }
		}


        async Task<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeFacadeObjects.CheckActivation(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().CheckActivation(cnf_smsactivationcode, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeFacade.CheckActivation"));
            }
        }

    }
}