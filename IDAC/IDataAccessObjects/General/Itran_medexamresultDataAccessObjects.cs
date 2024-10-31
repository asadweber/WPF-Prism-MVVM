using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_medexamresultDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
		
        Task<long> Update(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_medexamresultEntity> listAdded, IList<tran_medexamresultEntity> listUpdated, IList<tran_medexamresultEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_medexamresultEntity>> GetAll(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
		
        Task<IList<tran_medexamresultEntity>> GetAllByPages(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_medexamresultEntity> GetSingle(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_medexamresultEntity>> GAPgListView(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
