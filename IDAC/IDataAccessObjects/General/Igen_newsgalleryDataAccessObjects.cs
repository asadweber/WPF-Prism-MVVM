using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_newsgalleryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
		
        Task<long> Update(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_newsgalleryEntity> listAdded, IList<gen_newsgalleryEntity> listUpdated, IList<gen_newsgalleryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_newsgalleryEntity>> GetAll(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
		
        Task<IList<gen_newsgalleryEntity>> GetAllByPages(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_newsgalleryEntity> GetSingle(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_newsgalleryEntity>> GAPgListView(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
