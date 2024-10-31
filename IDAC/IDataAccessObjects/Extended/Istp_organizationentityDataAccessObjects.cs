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
	public partial interface Istp_organizationentityDataAccessObjects
    {
		
         Task<long> AddExt(stp_organizationentityEntity stp_organizationentity,CancellationToken cancellationToken);
       
         Task<IList<stp_organizationentityEntity>> GetAllExt(stp_organizationentityEntity stp_organizationentity,CancellationToken cancellationToken);
    }
}
