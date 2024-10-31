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
	public partial interface Igen_religionDataAccessObjects
    {
		
         Task<long> AddExt(gen_religionEntity gen_religion,CancellationToken cancellationToken);
       
         Task<IList<gen_religionEntity>> GetAllExt(gen_religionEntity gen_religion,CancellationToken cancellationToken);

        Task<IList<gen_religionEntity>> GetReligionDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken);

    }
}
