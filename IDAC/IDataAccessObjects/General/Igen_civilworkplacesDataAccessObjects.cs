using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_civilworkplacesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
		
        Task<long> Update(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_civilworkplacesEntity> listAdded, IList<gen_civilworkplacesEntity> listUpdated, IList<gen_civilworkplacesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_civilworkplacesEntity>> GetAll(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
		
        Task<IList<gen_civilworkplacesEntity>> GetAllByPages(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_civilworkplaces(gen_civilworkplacesEntity masterEntity, IList<gen_civilworkplacesEntity> listAdded, IList<gen_civilworkplacesEntity> listUpdated, IList<gen_civilworkplacesEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_civilworkplacesEntity> GetSingle(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_civilworkplacesEntity>> GAPgListView(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
