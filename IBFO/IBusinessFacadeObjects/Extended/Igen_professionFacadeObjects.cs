

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;


namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_professionFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(gen_professionEntity gen_profession, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<gen_professionEntity>> GetAllExt(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_professionEntity>> GAPgListViewExt(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_professionEntity>> GetProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        //For Web Admin
        [OperationContract]
        Task<IList<gen_professionEntity>> GetBatchCandidateTypeWiseProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_professionEntity>> GetAllProfessionbyProfessionGroupID(gen_professionEntity gen_profession, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<gen_professionEntity>> GetMultiBatchCandidateTypeWiseProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken);
    }
}
