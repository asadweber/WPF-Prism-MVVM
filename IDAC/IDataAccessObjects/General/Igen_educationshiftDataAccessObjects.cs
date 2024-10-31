using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_educationshiftDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
		
        Task<long> Update(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_educationshiftEntity> listAdded, IList<gen_educationshiftEntity> listUpdated, IList<gen_educationshiftEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_educationshiftEntity>> GetAll(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
		
        Task<IList<gen_educationshiftEntity>> GetAllByPages(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_educationinfo(gen_educationshiftEntity masterEntity, IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_educationshiftEntity> GetSingle(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_educationshiftEntity>> GAPgListView(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
