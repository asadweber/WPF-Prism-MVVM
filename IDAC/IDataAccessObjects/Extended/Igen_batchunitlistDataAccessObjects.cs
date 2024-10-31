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
    public partial interface Igen_batchunitlistDataAccessObjects
    {

        Task<long> AddExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);

        Task<IList<gen_batchunitlistEntity>> GetAllExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);

        Task<IList<gen_batchunitlistEntity>> GAPgListViewExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
    }
}
