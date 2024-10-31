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
    public partial interface Ireg_studentfilestorageDataAccessObjects
    {
        Task<long> AddExt(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
        Task<IList<reg_studentfilestorageEntity>> GetAllExt(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
        Task<long> DeletebyBasicInfoIDFileConfigID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
        Task<IList<reg_studentfilestorageEntity>> GetAllByBasicInfoID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
    }
}
