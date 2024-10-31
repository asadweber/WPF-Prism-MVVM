using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_usefullinkcategoryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
		
        Task<long> Update(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_usefullinkcategoryEntity> listAdded, IList<gen_usefullinkcategoryEntity> listUpdated, IList<gen_usefullinkcategoryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_usefullinkcategoryEntity>> GetAll(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
		
        Task<IList<gen_usefullinkcategoryEntity>> GetAllByPages(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_usefullink(gen_usefullinkcategoryEntity masterEntity, IList<gen_usefullinkEntity> listAdded, IList<gen_usefullinkEntity> listUpdated, IList<gen_usefullinkEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_usefullinkcategoryEntity> GetSingle(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_usefullinkcategoryEntity>> GAPgListView(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
