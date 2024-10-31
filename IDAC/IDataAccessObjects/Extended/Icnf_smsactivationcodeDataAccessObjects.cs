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
	public partial interface Icnf_smsactivationcodeDataAccessObjects
    {
		
         Task<long> AddExt(cnf_smsactivationcodeEntity cnf_smsactivationcode,CancellationToken cancellationToken);
       
         Task<IList<cnf_smsactivationcodeEntity>> GetAllExt(cnf_smsactivationcodeEntity cnf_smsactivationcode,CancellationToken cancellationToken);
        Task<cnf_smsactivationcodeEntity> CheckActivation(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
    }
}
