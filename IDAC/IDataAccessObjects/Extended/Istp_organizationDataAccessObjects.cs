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
	public partial interface Istp_organizationDataAccessObjects
    {
		
         Task<long> AddExt(stp_organizationEntity stp_organization,CancellationToken cancellationToken);
       
         Task<IList<stp_organizationEntity>> GetAllExt(stp_organizationEntity stp_organization,CancellationToken cancellationToken);
    }
}
