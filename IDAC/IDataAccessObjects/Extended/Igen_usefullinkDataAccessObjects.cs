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
	public partial interface Igen_usefullinkDataAccessObjects
    {
		
         Task<long> AddExt(gen_usefullinkEntity gen_usefullink,CancellationToken cancellationToken);
       
         Task<IList<gen_usefullinkEntity>> GetAllExt(gen_usefullinkEntity gen_usefullink,CancellationToken cancellationToken);
    }
}
