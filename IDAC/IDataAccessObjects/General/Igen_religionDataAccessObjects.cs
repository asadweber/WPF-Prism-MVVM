using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_religionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_religionEntity gen_religion, CancellationToken cancellationToken);
		
        Task<long> Update(gen_religionEntity gen_religion, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_religionEntity gen_religion, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_religionEntity> listAdded, IList<gen_religionEntity> listUpdated, IList<gen_religionEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_religionEntity>> GetAll(gen_religionEntity gen_religion, CancellationToken cancellationToken);
		
        Task<IList<gen_religionEntity>> GetAllByPages(gen_religionEntity gen_religion, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(gen_religionEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_religionEntity> GetSingle(gen_religionEntity gen_religion, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_religionEntity>> GAPgListView(gen_religionEntity gen_religion, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
