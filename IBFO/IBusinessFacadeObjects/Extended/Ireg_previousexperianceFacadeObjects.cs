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
    public partial interface Ireg_previousexperianceFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_previousexperianceEntity>> GetAllExt(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
         
    }
}
