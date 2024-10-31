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
    public partial interface Igen_companiesDataAccessObjects
    {
        Task<long> AddExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken);

        Task<IList<gen_companiesEntity>> GetAllExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken);

        Task<IList<gen_companiesEntity>> GAPgListViewExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
    }
}
