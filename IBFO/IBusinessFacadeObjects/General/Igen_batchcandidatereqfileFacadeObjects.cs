

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_batchcandidatereqfileFacadeObjects")]
    public partial interface Igen_batchcandidatereqfileFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_batchcandidatereqfileEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_batchcandidatereqfileEntity>> GetAll(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_batchcandidatereqfileEntity>> GetAllByPages(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_batchcandidatereqfileEntity> GetSingle(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_batchcandidatereqfileEntity>> GAPgListView(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
