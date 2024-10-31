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
    public partial interface Igen_professionDataAccessObjects
    {
        Task<long> AddExt(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        Task<IList<gen_professionEntity>> GetAllExt(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        Task<IList<gen_professionEntity>> GAPgListViewExt(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        Task<IList<gen_professionEntity>> GetProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken);
        
        Task<IList<gen_professionEntity>> GetBatchCandidateTypeWiseProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        Task<IList<gen_professionEntity>> GetMultiBatchCandidateTypeWiseProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        Task<IList<gen_professionEntity>> GetAllProfessionbyProfessionGroupID(gen_professionEntity gen_profession, CancellationToken cancellationToken);
    }
}
