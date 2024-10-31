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
    public partial interface Ireg_famillyDataAccessObjects
    {
        Task<reg_famillyEntity> GetSingleByIdWithDocument(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        Task<long> AddExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken);

        Task<IList<reg_famillyEntity>> GetAllExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        Task<long> SaveUpdateExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        Task<long> ApplicantReviewSaveUpdate(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        Task<IList<reg_famillyEntity>> GetAllSpouseByPage(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        //Task<IList<reg_famillyEntity>> CheckHasSpouce(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        Task<long> DeleteByFamilityId(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        Task<IList<reg_famillyEntity>> GetFamilyMembersByRelationshipType(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        Task<reg_famillyEntity> GetFamiliyMemberByRelationType(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
    }
}
