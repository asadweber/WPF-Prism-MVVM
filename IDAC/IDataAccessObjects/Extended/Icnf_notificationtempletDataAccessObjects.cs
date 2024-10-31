using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;



namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_notificationtempletDataAccessObjects
    {
		
         Task<long> AddExt(cnf_notificationtempletEntity cnf_notificationtemplet,CancellationToken cancellationToken);
       
         Task<IList<cnf_notificationtempletEntity>> GetAllExt(cnf_notificationtempletEntity cnf_notificationtemplet,CancellationToken cancellationToken);

        Task<IList<cnf_notificationtempletEntity>> GetNotificationTemplateWithMsgDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
    }
}
