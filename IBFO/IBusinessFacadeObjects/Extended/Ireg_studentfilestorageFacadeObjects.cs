

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_studentfilestorageFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_studentfilestorageEntity>> GetAllExt(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> DeletebyBasicInfoIDFileConfigID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_studentfilestorageEntity>> GetAllByBasicInfoID(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
    }
}
