

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_languageFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_languageEntity reg_language, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_languageEntity>> GetAllExt(reg_languageEntity reg_language, CancellationToken cancellationToken);
         
    }
}
