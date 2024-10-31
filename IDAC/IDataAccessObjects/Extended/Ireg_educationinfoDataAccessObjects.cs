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
    public partial interface Ireg_educationinfoDataAccessObjects
    {
        Task<long> AddExt(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        Task<IList<reg_educationinfoEntity>> GetAllExt(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        Task<IList<reg_educationinfoEntity>> GetAllByBasicInfoID(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        Task<reg_educationinfoEntity> GetSingleById(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        Task<long> AddOrUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        Task<long> ApllicantReviewEducationInfoSaveorUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        Task<long> DeleteWithAttachment(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
    }
}
