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
	public partial interface Igen_countryclassDataAccessObjects
    {
		
         Task<long> AddExt(gen_countryclassEntity gen_countryclass,CancellationToken cancellationToken);
       
         Task<IList<gen_countryclassEntity>> GetAllExt(gen_countryclassEntity gen_countryclass,CancellationToken cancellationToken);


        Task<IList<gen_countryclassEntity>> GetCountryClassDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);

    }
}
