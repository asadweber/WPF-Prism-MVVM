using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_newsDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_newsEntity gen_news, CancellationToken cancellationToken);
		
        Task<long> Update(gen_newsEntity gen_news, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_newsEntity gen_news, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_newsEntity> listAdded, IList<gen_newsEntity> listUpdated, IList<gen_newsEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_newsEntity>> GetAll(gen_newsEntity gen_news, CancellationToken cancellationToken);
		
        Task<IList<gen_newsEntity>> GetAllByPages(gen_newsEntity gen_news, CancellationToken cancellationToken);

        #endregion GetAll

        #region SaveMasterDetails
        Task<long> SaveMasterDetgen_newsgallery(gen_newsEntity masterEntity, IList<gen_newsgalleryEntity> listAdded, IList<gen_newsgalleryEntity> listUpdated, IList<gen_newsgalleryEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails

        #region Simple load Single Row
        Task<gen_newsEntity> GetSingle(gen_newsEntity gen_news, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_newsEntity>> GAPgListView(gen_newsEntity gen_news, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        Task<long > UpdatePublished(gen_newsEntity gen_news, CancellationToken cancellationToken);
        Task<long > UpdateReviewed(gen_newsEntity gen_news, CancellationToken cancellationToken);
        #endregion        
        
        
               
        
        
        
        
    }
}
