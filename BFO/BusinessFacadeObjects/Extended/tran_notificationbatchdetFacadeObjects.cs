
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
    public sealed partial class tran_notificationbatchdetFacadeObjects
    {
		
       async Task<long> Itran_notificationbatchdetFacadeObjects.AddExt(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().AddExt(tran_notificationbatchdet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchdetFacade.Addtran_notificationbatchdet"));
            }
		}
       
		async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetFacadeObjects.GetAllExt(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().GetAllExt(tran_notificationbatchdet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchdetEntity> Itran_notificationbatchdetFacade.GetAlltran_notificationbatchdet"));
            }
		}

        async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetFacadeObjects.GetAllByBasicInfoRegistrationID(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().GetAllByBasicInfoRegistrationID(tran_notificationbatchdet, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchdetEntity> Itran_notificationbatchdetFacade.GetAllByBasicInfoRegistrationID"));
            }
        }

    }
}