using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_hobbiesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
		
        Task<long> Update(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_hobbiesEntity> listAdded, IList<reg_hobbiesEntity> listUpdated, IList<reg_hobbiesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_hobbiesEntity>> GetAll(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
		
        Task<IList<reg_hobbiesEntity>> GetAllByPages(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_hobbiesEntity> GetSingle(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_hobbiesEntity>> GAPgListView(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
