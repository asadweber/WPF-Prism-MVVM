using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_finalexamresultDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
		
        Task<long> Update(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_finalexamresultEntity> listAdded, IList<tran_finalexamresultEntity> listUpdated, IList<tran_finalexamresultEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_finalexamresultEntity>> GetAll(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
		
        Task<IList<tran_finalexamresultEntity>> GetAllByPages(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_finalexamresultEntity> GetSingle(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_finalexamresultEntity>> GAPgListView(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
