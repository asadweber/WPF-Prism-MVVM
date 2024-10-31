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
	public partial interface Ireg_nonkuwaitystatusDataAccessObjects
    {
		
         Task<long> AddExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus,CancellationToken cancellationToken);
       
         Task<IList<reg_nonkuwaitystatusEntity>> GetAllExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus,CancellationToken cancellationToken);
    }
}
