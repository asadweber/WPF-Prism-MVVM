

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_batchunitlistFacadeObjects")]
    public partial interface Igen_batchunitlistFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_batchunitlistEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_batchunitlistEntity>> GetAll(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_batchunitlistEntity>> GetAllByPages(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_batchunitlistEntity> GetSingle(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_batchunitlistEntity>> GAPgListView(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
