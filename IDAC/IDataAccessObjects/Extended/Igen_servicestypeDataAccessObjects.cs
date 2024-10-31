﻿using System;
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
	public partial interface Igen_servicestypeDataAccessObjects
    {
		
         Task<long> AddExt(gen_servicestypeEntity gen_servicestype,CancellationToken cancellationToken);
       
         Task<IList<gen_servicestypeEntity>> GetAllExt(gen_servicestypeEntity gen_servicestype,CancellationToken cancellationToken);
    }
}
