

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Icnf_smsactivationtransectionFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<cnf_smsactivationtransectionEntity>> GetAllExt(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
         
    }
}
