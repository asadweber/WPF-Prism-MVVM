using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;
using BDO.DataAccessObjects.VCRegistration;
using BDO.Report;
using BDO.DataAccessObjects.VCApplicantReview;

namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Ireg_basicinfoDataAccessObjects
    {

        Task<long> AddExt(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<IList<reg_basicinfoEntity>> GetAllExt(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<reg_basicinfoEntity> ValidateMobileNumber(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
        Task<reg_basicinfoEntity> ValidateEmailAddress(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<reg_basicinfoEntity> ValidateCivilIdPolicy(string CivilId, long? BatchId, CancellationToken cancellationToken);
        Task<long> SavePreRegistration(RegistrationViewModel request, CancellationToken cancellationToken);
        Task<long> SubmitFinalRegistration(RegistrationViewModel request, CancellationToken cancellationToken);

        Task<RegistrationViewModel> GetRegisteredApplicantProfileDataByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<RegistrationViewModel> GetRegistrationDetailsByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<RegistrationViewModel> GetRegisteredApplicantProfileDataByCivilIdForDelete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<IList<reg_basicinfoEntity>> GetAllRegBasicInfoByMultipleBasicID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<long> RollbackFinalSubmit(RegistrationViewModel request, CancellationToken cancellationToken);

        Task<ProfileReportEntity> GetRegistrationProfileDataWithDetailByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<ApplicantReviewViewModel> GetRegisteredApplicantProfileDataByBasicInfoId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<RegistrationViewModel> GetRegisteredApplicantCurrentBatchDataByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<long> SaveApplicantReviewBasicInfo(ApplicantReviewViewModel request, CancellationToken cancellationToken);


        Task<long> RegisterAnotherBatchSave(RegistrationViewModel request, CancellationToken cancellationToken);

        Task<Reg_ApplicantDataCheckedEntity> GetRegistrationDataInfoStatusCheck(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<long> DeleteApplicantbyBasicInfoID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        Task<long> UpdateApplicantContactInfo(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

    }
}
