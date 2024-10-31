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
	public partial interface Istp_organizationentitytypeDataAccessObjects
    {
		
         Task<long> AddExt(stp_organizationentitytypeEntity stp_organizationentitytype,CancellationToken cancellationToken);
       
         Task<IList<stp_organizationentitytypeEntity>> GetAllExt(stp_organizationentitytypeEntity stp_organizationentitytype,CancellationToken cancellationToken);
    }
}
