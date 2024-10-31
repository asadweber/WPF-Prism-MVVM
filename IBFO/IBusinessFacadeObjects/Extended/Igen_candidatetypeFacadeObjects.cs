

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_candidatetypeFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_candidatetypeEntity>> GetAllExt(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);


        [OperationContract]
        Task<IList<gen_candidatetypeEntity>> GetBatchWiseCandidateTypeDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);

        //For Web Admin
        [OperationContract]
        Task<IList<gen_candidatetypeEntity>> GetBatchWiseCandidateTypeListDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);

        //For Web Admin
        [OperationContract]
        Task<IList<gen_candidatetypeEntity>> GetMultiBatchWiseCandidateTypeListDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);

        [OperationContract]
        Task<gen_candidatetypeEntity> GetSingleById(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
    }
}
