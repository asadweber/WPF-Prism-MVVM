using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_applyanotherbatchDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
		
        Task<long> Update(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_applyanotherbatchEntity> listAdded, IList<tran_applyanotherbatchEntity> listUpdated, IList<tran_applyanotherbatchEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_applyanotherbatchEntity>> GetAll(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
		
        Task<IList<tran_applyanotherbatchEntity>> GetAllByPages(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_applyanotherbatchEntity> GetSingle(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_applyanotherbatchEntity>> GAPgListView(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
