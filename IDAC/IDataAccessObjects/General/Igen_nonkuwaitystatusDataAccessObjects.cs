using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_nonkuwaitystatusDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
		
        Task<long> Update(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_nonkuwaitystatusEntity> listAdded, IList<gen_nonkuwaitystatusEntity> listUpdated, IList<gen_nonkuwaitystatusEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_nonkuwaitystatusEntity>> GetAll(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
		
        Task<IList<gen_nonkuwaitystatusEntity>> GetAllByPages(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_nonkuwaitystatus(gen_nonkuwaitystatusEntity masterEntity, IList<reg_nonkuwaitystatusEntity> listAdded, IList<reg_nonkuwaitystatusEntity> listUpdated, IList<reg_nonkuwaitystatusEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_nonkuwaitystatusEntity> GetSingle(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_nonkuwaitystatusEntity>> GAPgListView(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
