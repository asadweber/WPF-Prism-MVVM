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
    public partial interface Igen_batchcandidatereqfileDataAccessObjects
    {

        Task<long> AddExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);

        Task<IList<gen_batchcandidatereqfileEntity>> GetAllExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);

        Task<IList<gen_batchcandidatereqfileEntity>> GAPgListViewExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);

        Task<gen_batchcandidatereqfileEntity> GetSingleExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
    }
}
