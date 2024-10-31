using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_rankDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_rankEntity gen_rank, CancellationToken cancellationToken);
		
        Task<long> Update(gen_rankEntity gen_rank, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_rankEntity gen_rank, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_rankEntity> listAdded, IList<gen_rankEntity> listUpdated, IList<gen_rankEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_rankEntity>> GetAll(gen_rankEntity gen_rank, CancellationToken cancellationToken);
		
        Task<IList<gen_rankEntity>> GetAllByPages(gen_rankEntity gen_rank, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_rankEntity> GetSingle(gen_rankEntity gen_rank, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_rankEntity>> GAPgListView(gen_rankEntity gen_rank, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
