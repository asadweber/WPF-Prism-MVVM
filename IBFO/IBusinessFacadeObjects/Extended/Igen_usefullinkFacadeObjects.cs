﻿

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_usefullinkFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_usefullinkEntity>> GetAllExt(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
         
    }
}
