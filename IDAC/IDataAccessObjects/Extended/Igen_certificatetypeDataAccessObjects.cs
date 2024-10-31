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
	public partial interface Igen_certificatetypeDataAccessObjects
    {
		
         Task<long> AddExt(gen_certificatetypeEntity gen_certificatetype,CancellationToken cancellationToken);
       
         Task<IList<gen_certificatetypeEntity>> GetAllExt(gen_certificatetypeEntity gen_certificatetype,CancellationToken cancellationToken);
    }
}
