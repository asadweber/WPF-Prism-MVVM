using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Icnf_notificationconfigDataAccessObjects
    {

        Task<long> AddExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);

        Task<IList<cnf_notificationconfigEntity>> GetAllExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);

        Task<IList<cnf_notificationconfigEntity>> GAPgListViewExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);

        Task<IList<gen_dropdownEntity>> GetDataForDropDownExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
    }
}
