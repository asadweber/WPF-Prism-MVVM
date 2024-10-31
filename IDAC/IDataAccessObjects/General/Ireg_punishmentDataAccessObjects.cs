using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_punishmentDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
		
        Task<long> Update(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_punishmentEntity> listAdded, IList<reg_punishmentEntity> listUpdated, IList<reg_punishmentEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_punishmentEntity>> GetAll(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
		
        Task<IList<reg_punishmentEntity>> GetAllByPages(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_punishmentEntity> GetSingle(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_punishmentEntity>> GAPgListView(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
