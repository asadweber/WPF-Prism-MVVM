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
	public partial interface Igen_countrycityDataAccessObjects
    {
		
         Task<long> AddExt(gen_countrycityEntity gen_countrycity,CancellationToken cancellationToken);
       
         Task<IList<gen_countrycityEntity>> GetAllExt(gen_countrycityEntity gen_countrycity,CancellationToken cancellationToken);

         Task<IList<gen_countrycityEntity>> GetGovernateDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);

        Task<bool> CheckHasGovernarate(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
    }
}
