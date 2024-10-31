

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.VCApplicantReview;
using BDO.DataAccessObjects.VCRegistration;
using BDO.Report;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_basicinfoFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_basicinfoEntity>> GetAllExt(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_basicinfoEntity> ValidateMobileNumber(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
       
        [OperationContract]
        Task<reg_basicinfoEntity> ValidateEmailAddress(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_basicinfoEntity> ValidateCivilIdPolicy(string CivilId,long? BatchId, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SavePreRegistration(RegistrationViewModel request, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SubmitFinalRegistration(RegistrationViewModel request, CancellationToken cancellationToken);

        [OperationContract]
        Task<RegistrationViewModel> GetRegisteredApplicantProfileDataByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<RegistrationViewModel> GetRegistrationDetailsByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<RegistrationViewModel> GetRegisteredApplicantProfileDataByCivilIdForDelete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_basicinfoEntity>> GetAllRegBasicInfoByMultipleBasicID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> RollbackFinalSubmit(RegistrationViewModel request, CancellationToken cancellationToken);

        [OperationContract]
        Task<ProfileReportEntity> GetRegistrationProfileDataWithDetailByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<ApplicantReviewViewModel> GetRegisteredApplicantProfileDataByBasicInfoId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<RegistrationViewModel> GetRegisteredApplicantCurrentBatchDataByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveApplicantReviewBasicInfo(ApplicantReviewViewModel request, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> RegisterAnotherBatchSave(RegistrationViewModel request, CancellationToken cancellationToken);

        [OperationContract]
        Task<Reg_ApplicantDataCheckedEntity> GetRegistrationDataInfoStatusCheck(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> DeleteApplicantbyBasicInfoID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> UpdateApplicantContactInfo(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);

    }
}
