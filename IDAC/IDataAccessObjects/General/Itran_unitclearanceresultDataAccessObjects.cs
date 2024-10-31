using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_unitclearanceresultDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
		
        Task<long> Update(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_unitclearanceresultEntity> listAdded, IList<tran_unitclearanceresultEntity> listUpdated, IList<tran_unitclearanceresultEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_unitclearanceresultEntity>> GetAll(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
		
        Task<IList<tran_unitclearanceresultEntity>> GetAllByPages(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_unitclearanceresultEntity> GetSingle(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_unitclearanceresultEntity>> GAPgListView(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
