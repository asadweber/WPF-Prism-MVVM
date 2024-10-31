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
	public partial interface Igen_statusDataAccessObjects
    {
		
         Task<long> AddExt(gen_statusEntity gen_status,CancellationToken cancellationToken);
       
         Task<IList<gen_statusEntity>> GetAllExt(gen_statusEntity gen_status,CancellationToken cancellationToken);
    }
}
