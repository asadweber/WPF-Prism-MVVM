using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_medexamnotificationDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
		
        Task<long> Update(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_medexamnotificationEntity> listAdded, IList<tran_medexamnotificationEntity> listUpdated, IList<tran_medexamnotificationEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_medexamnotificationEntity>> GetAll(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
		
        Task<IList<tran_medexamnotificationEntity>> GetAllByPages(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_medexamnotificationEntity> GetSingle(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_medexamnotificationEntity>> GAPgListView(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
