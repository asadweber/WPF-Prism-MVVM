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
	public partial interface Icnf_smstempaltesDataAccessObjects
    {
		
         Task<long> AddExt(cnf_smstempaltesEntity cnf_smstempaltes,CancellationToken cancellationToken);
       
         Task<IList<cnf_smstempaltesEntity>> GetAllExt(cnf_smstempaltesEntity cnf_smstempaltes,CancellationToken cancellationToken);
    }
}
