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
	public partial interface Itran_rollbackinfoDataAccessObjects
    {
		
         Task<long> AddExt(tran_rollbackinfoEntity tran_rollbackinfo,CancellationToken cancellationToken);
       
         Task<IList<tran_rollbackinfoEntity>> GetAllExt(tran_rollbackinfoEntity tran_rollbackinfo,CancellationToken cancellationToken);
    }
}
