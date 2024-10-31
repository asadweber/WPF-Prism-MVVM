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
	public partial interface Icnf_filerequiredDataAccessObjects
    {
		
         Task<long> AddExt(cnf_filerequiredEntity cnf_filerequired,CancellationToken cancellationToken);
       
         Task<IList<cnf_filerequiredEntity>> GetAllExt(cnf_filerequiredEntity cnf_filerequired,CancellationToken cancellationToken);

        Task<IList<cnf_filerequiredEntity>> GAPgListViewExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
    }
}
