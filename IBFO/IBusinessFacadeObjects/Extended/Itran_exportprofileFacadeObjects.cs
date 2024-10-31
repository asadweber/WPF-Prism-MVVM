

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Itran_exportprofileFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<tran_exportprofileEntity>> GetAllExt(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
         
    }
}
