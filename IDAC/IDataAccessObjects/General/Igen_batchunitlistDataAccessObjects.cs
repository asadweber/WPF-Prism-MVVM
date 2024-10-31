using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_batchunitlistDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
		
        Task<long> Update(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_batchunitlistEntity> listAdded, IList<gen_batchunitlistEntity> listUpdated, IList<gen_batchunitlistEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_batchunitlistEntity>> GetAll(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
		
        Task<IList<gen_batchunitlistEntity>> GetAllByPages(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_batchunitlistEntity> GetSingle(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_batchunitlistEntity>> GAPgListView(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
