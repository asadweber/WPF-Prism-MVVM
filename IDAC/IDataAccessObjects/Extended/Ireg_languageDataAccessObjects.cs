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
	public partial interface Ireg_languageDataAccessObjects
    {
		
         Task<long> AddExt(reg_languageEntity reg_language,CancellationToken cancellationToken);
       
         Task<IList<reg_languageEntity>> GetAllExt(reg_languageEntity reg_language,CancellationToken cancellationToken);
    }
}
