using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_batchcandprofessionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
		
        Task<long> Update(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_batchcandprofessionEntity> listAdded, IList<gen_batchcandprofessionEntity> listUpdated, IList<gen_batchcandprofessionEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_batchcandprofessionEntity>> GetAll(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
		
        Task<IList<gen_batchcandprofessionEntity>> GetAllByPages(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_batchcandprofessionEntity> GetSingle(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_batchcandprofessionEntity>> GAPgListView(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
