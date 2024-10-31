using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_syexamresultDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
		
        Task<long> Update(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_syexamresultEntity> listAdded, IList<tran_syexamresultEntity> listUpdated, IList<tran_syexamresultEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_syexamresultEntity>> GetAll(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
		
        Task<IList<tran_syexamresultEntity>> GetAllByPages(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_syexamresultEntity> GetSingle(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_syexamresultEntity>> GAPgListView(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
