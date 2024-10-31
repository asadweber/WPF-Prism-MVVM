using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_syexamnotificationDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
		
        Task<long> Update(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_syexamnotificationEntity> listAdded, IList<tran_syexamnotificationEntity> listUpdated, IList<tran_syexamnotificationEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_syexamnotificationEntity>> GetAll(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
		
        Task<IList<tran_syexamnotificationEntity>> GetAllByPages(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_syexamnotificationEntity> GetSingle(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_syexamnotificationEntity>> GAPgListView(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
