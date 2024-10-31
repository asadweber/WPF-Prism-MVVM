﻿using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Igen_batchcandidatetypemapDataAccessObjects
    {

        Task<long> AddExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<IList<gen_batchcandidatetypemapEntity>> GetAllExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<IList<gen_batchcandidatetypemapEntity>> GAPgListViewExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<IList<gen_dropdownEntity>> GetDataForDropDownExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);

        Task<gen_batchcandidatetypemapEntity> GetSingleByBatchCandidateTypeID(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
    }
}
