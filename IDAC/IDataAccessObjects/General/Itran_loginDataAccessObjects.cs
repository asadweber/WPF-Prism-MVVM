using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_loginDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_loginEntity tran_login, CancellationToken cancellationToken);
		
        Task<long> Update(tran_loginEntity tran_login, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_loginEntity tran_login, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_loginEntity> listAdded, IList<tran_loginEntity> listUpdated, IList<tran_loginEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_loginEntity>> GetAll(tran_loginEntity tran_login, CancellationToken cancellationToken);
		
        Task<IList<tran_loginEntity>> GetAllByPages(tran_loginEntity tran_login, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_loginEntity> GetSingle(tran_loginEntity tran_login, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_loginEntity>> GAPgListView(tran_loginEntity tran_login, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
