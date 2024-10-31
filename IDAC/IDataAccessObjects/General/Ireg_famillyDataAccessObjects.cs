using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_famillyDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
		
        Task<long> Update(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_famillyEntity>> GetAll(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
		
        Task<IList<reg_famillyEntity>> GetAllByPages(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(reg_famillyEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_nonkuwaitystatus(reg_famillyEntity masterEntity, IList<reg_nonkuwaitystatusEntity> listAdded, IList<reg_nonkuwaitystatusEntity> listUpdated, IList<reg_nonkuwaitystatusEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_famillyEntity> GetSingle(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_famillyEntity>> GAPgListView(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_famillyEntity reg_familly, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
