

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_smsactivationcodeFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<cnf_smsactivationcodeEntity>> GetAllExt(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);

        [OperationContract]
        Task<cnf_smsactivationcodeEntity> CheckActivation(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);


    }
}
