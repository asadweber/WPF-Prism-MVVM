

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_emergencycontactinfoFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_emergencycontactinfoEntity>> GetAllExt(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);


		[OperationContract]
		Task<long> AddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> ApplicantReviewAddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_emergencycontactinfoEntity> GetSingleById(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> DeleteRegEmgContactInfoWithRelativesWorkingInMOD(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
    }
}
