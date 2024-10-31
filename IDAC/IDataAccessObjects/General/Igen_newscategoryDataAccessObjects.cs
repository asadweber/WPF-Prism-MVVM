using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_newscategoryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
		
        Task<long> Update(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_newscategoryEntity> listAdded, IList<gen_newscategoryEntity> listUpdated, IList<gen_newscategoryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_newscategoryEntity>> GetAll(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
		
        Task<IList<gen_newscategoryEntity>> GetAllByPages(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_news(gen_newscategoryEntity masterEntity, IList<gen_newsEntity> listAdded, IList<gen_newsEntity> listUpdated, IList<gen_newsEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_newscategory(gen_newscategoryEntity masterEntity, IList<gen_newscategoryEntity> listAdded, IList<gen_newscategoryEntity> listUpdated, IList<gen_newscategoryEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_newscategoryEntity> GetSingle(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_newscategoryEntity>> GAPgListView(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
