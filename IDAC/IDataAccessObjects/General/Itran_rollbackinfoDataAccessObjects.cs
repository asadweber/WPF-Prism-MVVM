using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_rollbackinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
		
        Task<long> Update(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_rollbackinfoEntity> listAdded, IList<tran_rollbackinfoEntity> listUpdated, IList<tran_rollbackinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_rollbackinfoEntity>> GetAll(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
		
        Task<IList<tran_rollbackinfoEntity>> GetAllByPages(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_rollbackinfoEntity> GetSingle(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_rollbackinfoEntity>> GAPgListView(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
