﻿

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_residenttypeFacadeObjects : IDisposable
    { 
		
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_residenttypeEntity>> GetResidentTypeDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken); 
		#endregion
    
    }
}
