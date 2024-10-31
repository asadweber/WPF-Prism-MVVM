using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_educationgradeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
		
        Task<long> Update(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_educationgradeEntity> listAdded, IList<gen_educationgradeEntity> listUpdated, IList<gen_educationgradeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_educationgradeEntity>> GetAll(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
		
        Task<IList<gen_educationgradeEntity>> GetAllByPages(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_educationinfo(gen_educationgradeEntity masterEntity, IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_educationgradeEntity> GetSingle(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_educationgradeEntity>> GAPgListView(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
