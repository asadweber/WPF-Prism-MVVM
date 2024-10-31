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
	public partial interface Igen_bloodgroupDataAccessObjects
    {
		
         Task<long> AddExt(gen_bloodgroupEntity gen_bloodgroup,CancellationToken cancellationToken);
       
         Task<IList<gen_bloodgroupEntity>> GetAllExt(gen_bloodgroupEntity gen_bloodgroup,CancellationToken cancellationToken);

        Task<IList<gen_bloodgroupEntity>> GetBloodGroupDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
    }
}
