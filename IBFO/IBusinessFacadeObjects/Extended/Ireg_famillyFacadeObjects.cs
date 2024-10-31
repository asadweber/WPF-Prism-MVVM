

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_famillyFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_famillyEntity>> GetAllExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveUpdate(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> ApplicantReviewSaveUpdate(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_famillyEntity>> GetAllSpouseByPage(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        //[OperationContract]
        //Task<IList<reg_famillyEntity>> CheckHasSpouce(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        [OperationContract] 
        Task<long> DeleteByFamilityId(reg_famillyEntity reg_familly, CancellationToken cancellationToken);


        [OperationContract]
        Task<IList<reg_famillyEntity>> GetFamilyMembersByRelationshipType(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_famillyEntity> GetSingleByIdWithDocument(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

    }
}
