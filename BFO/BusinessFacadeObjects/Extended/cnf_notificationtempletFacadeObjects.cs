
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
    public sealed partial class cnf_notificationtempletFacadeObjects
    {
		
       async Task<long> Icnf_notificationtempletFacadeObjects.AddExt(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().AddExt(cnf_notificationtemplet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationtempletFacade.Addcnf_notificationtemplet"));
            }
		}
       
		async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletFacadeObjects.GetAllExt(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().GetAllExt(cnf_notificationtemplet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationtempletEntity> Icnf_notificationtempletFacade.GetAllcnf_notificationtemplet"));
            }
		}

        async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletFacadeObjects.GetNotificationTemplateWithMsgDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_notificationtempletDataAccess().GetNotificationTemplateWithMsgDropDown(cnf_notificationtemplet, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationtempletEntity> Icnf_notificationtempletFacade.GetNotificationTemplateWithMsgDropDown"));
            }
        }

    }
}