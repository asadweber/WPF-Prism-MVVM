
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
    public sealed partial class cnf_notificationconfigdetlFacadeObjects
    {
		
       async Task<long> Icnf_notificationconfigdetlFacadeObjects.AddExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().AddExt(cnf_notificationconfigdetl, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigdetlFacade.Addcnf_notificationconfigdetl"));
            }
		}
       
		async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlFacadeObjects.GetAllExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().GetAllExt(cnf_notificationconfigdetl, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlFacade.GetAllcnf_notificationconfigdetl"));
            }
		}

        async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlFacadeObjects.GAPgListViewExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().GAPgListViewExt(cnf_notificationconfigdetl, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlFacade.GAPgListViewExtcnf_notificationconfigdetl"));
            }
        }

        async Task<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlFacadeObjects.GetSingleExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().GetSingleExt(cnf_notificationconfigdetl, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_notificationconfigdetlEntity Icnf_notificationconfigdetlFacade.GetSingleExtcnf_notificationconfigdetl"));
            }
        }

    }
}