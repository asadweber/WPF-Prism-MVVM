using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_auditresultDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
		
        Task<long> Update(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_auditresultEntity> listAdded, IList<tran_auditresultEntity> listUpdated, IList<tran_auditresultEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_auditresultEntity>> GetAll(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
		
        Task<IList<tran_auditresultEntity>> GetAllByPages(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_auditresultEntity> GetSingle(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_auditresultEntity>> GAPgListView(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
