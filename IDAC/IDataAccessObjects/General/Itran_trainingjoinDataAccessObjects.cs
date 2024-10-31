using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_trainingjoinDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
		
        Task<long> Update(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_trainingjoinEntity> listAdded, IList<tran_trainingjoinEntity> listUpdated, IList<tran_trainingjoinEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_trainingjoinEntity>> GetAll(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
		
        Task<IList<tran_trainingjoinEntity>> GetAllByPages(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_trainingjoinEntity> GetSingle(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_trainingjoinEntity>> GAPgListView(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
