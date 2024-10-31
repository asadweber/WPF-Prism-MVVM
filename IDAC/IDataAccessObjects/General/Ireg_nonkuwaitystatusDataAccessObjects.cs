using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_nonkuwaitystatusDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
		
        Task<long> Update(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_nonkuwaitystatusEntity> listAdded, IList<reg_nonkuwaitystatusEntity> listUpdated, IList<reg_nonkuwaitystatusEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_nonkuwaitystatusEntity>> GetAll(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
		
        Task<IList<reg_nonkuwaitystatusEntity>> GetAllByPages(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_nonkuwaitystatusEntity> GetSingle(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_nonkuwaitystatusEntity>> GAPgListView(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
