using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_psychoexamresultDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
		
        Task<long> Update(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_psychoexamresultEntity> listAdded, IList<tran_psychoexamresultEntity> listUpdated, IList<tran_psychoexamresultEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_psychoexamresultEntity>> GetAll(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
		
        Task<IList<tran_psychoexamresultEntity>> GetAllByPages(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_psychoexamresultEntity> GetSingle(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_psychoexamresultEntity>> GAPgListView(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
