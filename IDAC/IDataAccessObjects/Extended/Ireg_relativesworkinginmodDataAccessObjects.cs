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
	public partial interface Ireg_relativesworkinginmodDataAccessObjects
    {
		
         Task<long> AddExt(reg_relativesworkinginmodEntity reg_relativesworkinginmod,CancellationToken cancellationToken);
       
         Task<IList<reg_relativesworkinginmodEntity>> GetAllExt(reg_relativesworkinginmodEntity reg_relativesworkinginmod,CancellationToken cancellationToken);
    }
}
