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
	public partial interface Igen_genderDataAccessObjects
    {
		
         Task<long> AddExt(gen_genderEntity gen_gender,CancellationToken cancellationToken);
       
         Task<IList<gen_genderEntity>> GetAllExt(gen_genderEntity gen_gender,CancellationToken cancellationToken);
    }
}
