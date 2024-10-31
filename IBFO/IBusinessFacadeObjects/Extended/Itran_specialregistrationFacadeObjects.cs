

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Itran_specialregistrationFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<tran_specialregistrationEntity>> GetAllExt(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
         
    }
}
