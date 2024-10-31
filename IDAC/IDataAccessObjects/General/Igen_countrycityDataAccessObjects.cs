using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_countrycityDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
		
        Task<long> Update(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_countrycityEntity> listAdded, IList<gen_countrycityEntity> listUpdated, IList<gen_countrycityEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_countrycityEntity>> GetAll(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
		
        Task<IList<gen_countrycityEntity>> GetAllByPages(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_civilworkplaces(gen_countrycityEntity masterEntity, IList<gen_civilworkplacesEntity> listAdded, IList<gen_civilworkplacesEntity> listUpdated, IList<gen_civilworkplacesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_countrycity(gen_countrycityEntity masterEntity, IList<gen_countrycityEntity> listAdded, IList<gen_countrycityEntity> listUpdated, IList<gen_countrycityEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_familly(gen_countrycityEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_countrycityEntity> GetSingle(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_countrycityEntity>> GAPgListView(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
