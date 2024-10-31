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
	public partial interface Itran_applicantphasesDataAccessObjects
    {
		
         Task<long> AddExt(tran_applicantphasesEntity tran_applicantphases,CancellationToken cancellationToken);
       
         Task<IList<tran_applicantphasesEntity>> GetAllExt(tran_applicantphasesEntity tran_applicantphases,CancellationToken cancellationToken);
    }
}
