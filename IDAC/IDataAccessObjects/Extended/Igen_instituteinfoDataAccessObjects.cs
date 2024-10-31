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
    public partial interface Igen_instituteinfoDataAccessObjects
    {
        Task<long> AddExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);

        Task<IList<gen_instituteinfoEntity>> GetAllExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);

        Task<IList<gen_instituteinfoEntity>> GetInstituteInfoDataForDropDown(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);

        Task<IList<gen_instituteinfoEntity>> GAPgListViewExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
    }
}
