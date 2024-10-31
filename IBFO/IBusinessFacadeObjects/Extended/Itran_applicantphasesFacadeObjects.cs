

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Itran_applicantphasesFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<tran_applicantphasesEntity>> GetAllExt(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
         
    }
}
