

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_educationinfoFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_educationinfoEntity>> GetAllExt(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<IList<reg_educationinfoEntity>> GetAllByBasicInfoID(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_educationinfoEntity> GetSingleById(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> AddOrUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> ApllicantReviewEducationInfoSaveorUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> DeleteWithAttachment(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);

    }
}
