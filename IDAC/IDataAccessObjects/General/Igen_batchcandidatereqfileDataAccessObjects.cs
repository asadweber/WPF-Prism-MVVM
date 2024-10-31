using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_batchcandidatereqfileDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
		
        Task<long> Update(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_batchcandidatereqfileEntity> listAdded, IList<gen_batchcandidatereqfileEntity> listUpdated, IList<gen_batchcandidatereqfileEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_batchcandidatereqfileEntity>> GetAll(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
		
        Task<IList<gen_batchcandidatereqfileEntity>> GetAllByPages(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_batchcandidatereqfileEntity> GetSingle(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_batchcandidatereqfileEntity>> GAPgListView(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
