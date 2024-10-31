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
	public partial interface Ireg_punishmentDataAccessObjects
    {
		
         Task<long> AddExt(reg_punishmentEntity reg_punishment,CancellationToken cancellationToken);
       
         Task<IList<reg_punishmentEntity>> GetAllExt(reg_punishmentEntity reg_punishment,CancellationToken cancellationToken);
    }
}
