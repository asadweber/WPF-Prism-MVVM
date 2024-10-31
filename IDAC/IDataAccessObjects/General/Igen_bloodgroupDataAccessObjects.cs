using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_bloodgroupDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
		
        Task<long> Update(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_bloodgroupEntity> listAdded, IList<gen_bloodgroupEntity> listUpdated, IList<gen_bloodgroupEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_bloodgroupEntity>> GetAll(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
		
        Task<IList<gen_bloodgroupEntity>> GetAllByPages(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(gen_bloodgroupEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_bloodgroupEntity> GetSingle(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_bloodgroupEntity>> GAPgListView(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
