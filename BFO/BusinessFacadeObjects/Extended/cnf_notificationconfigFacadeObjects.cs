
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
    public sealed partial class cnf_notificationconfigFacadeObjects
    {
		
       async Task<long> Icnf_notificationconfigFacadeObjects.AddExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().AddExt(cnf_notificationconfig, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigFacade.Addcnf_notificationconfig"));
            }
		}
       
		async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigFacadeObjects.GetAllExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GetAllExt(cnf_notificationconfig, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigEntity> Icnf_notificationconfigFacade.GetAllcnf_notificationconfig"));
            }
		}

        async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigFacadeObjects.GAPgListViewExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GAPgListViewExt(cnf_notificationconfig, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigEntity> Icnf_notificationconfigFacade.GAPgListViewExtcnf_notificationconfig"));
            }
        }

        async Task<IList<gen_dropdownEntity>> Icnf_notificationconfigFacadeObjects.GetDataForDropDownExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GetDataForDropDownExt(cnf_notificationconfig, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigEntity> Icnf_notificationconfigFacade.GetDataForDropDownExt"));
            }
        }

    }
}