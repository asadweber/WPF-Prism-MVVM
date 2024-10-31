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
    public partial interface Ireg_emergencycontactinfoDataAccessObjects
    {
        Task<long> AddExt(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        Task<IList<reg_emergencycontactinfoEntity>> GetAllExt(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        Task<long> AddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        Task<long> ApplicantReviewAddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        Task<reg_emergencycontactinfoEntity> GetSingleById(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        Task<long> DeleteRegEmgContactInfoWithRelativesWorkingInMOD(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
    }
}
