using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_imagegallarycategoryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
		
        Task<long> Update(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_imagegallarycategoryEntity> listAdded, IList<gen_imagegallarycategoryEntity> listUpdated, IList<gen_imagegallarycategoryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_imagegallarycategoryEntity>> GetAll(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
		
        Task<IList<gen_imagegallarycategoryEntity>> GetAllByPages(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_imagegallary(gen_imagegallarycategoryEntity masterEntity, IList<gen_imagegallaryEntity> listAdded, IList<gen_imagegallaryEntity> listUpdated, IList<gen_imagegallaryEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_imagegallarycategoryEntity> GetSingle(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_imagegallarycategoryEntity>> GAPgListView(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
