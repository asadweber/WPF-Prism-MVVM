﻿using System;
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
	public partial interface Icnf_studentmenuskipdetailDataAccessObjects
    {
		
         Task<long> AddExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail,CancellationToken cancellationToken);
       
         Task<IList<cnf_studentmenuskipdetailEntity>> GetAllExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail,CancellationToken cancellationToken);
    }
}
