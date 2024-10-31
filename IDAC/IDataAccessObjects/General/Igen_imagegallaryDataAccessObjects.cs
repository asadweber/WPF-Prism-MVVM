using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_imagegallaryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
		
        Task<long> Update(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_imagegallaryEntity> listAdded, IList<gen_imagegallaryEntity> listUpdated, IList<gen_imagegallaryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_imagegallaryEntity>> GetAll(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
		
        Task<IList<gen_imagegallaryEntity>> GetAllByPages(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_imagegallaryEntity> GetSingle(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_imagegallaryEntity>> GAPgListView(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
