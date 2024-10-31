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
	public partial interface Igen_certificatelevelDataAccessObjects
    {
		
         Task<long> AddExt(gen_certificatelevelEntity gen_certificatelevel,CancellationToken cancellationToken);
       
         Task<IList<gen_certificatelevelEntity>> GetAllExt(gen_certificatelevelEntity gen_certificatelevel,CancellationToken cancellationToken);
        Task<IList<gen_certificatelevelEntity>> GetCertificateLevelDataForDropDown(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
    }
}
