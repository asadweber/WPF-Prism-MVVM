
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
    public sealed partial class tran_notificationbatchFacadeObjects
    {
		
       async Task<long> Itran_notificationbatchFacadeObjects.AddExt(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().AddExt(tran_notificationbatch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchFacade.Addtran_notificationbatch"));
            }
		}
       
		async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchFacadeObjects.GetAllExt(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().GetAllExt(tran_notificationbatch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchEntity> Itran_notificationbatchFacade.GetAlltran_notificationbatch"));
            }
		}

        async Task<long> Itran_notificationbatchFacadeObjects.SaveNotificationBatchWithProfileList(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_notificationbatchDataAccess().SaveNotificationBatchWithProfileList(tran_notificationbatch, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchFacade.SaveNotificationBatchWithProfileList"));
            }
        }

    }
}