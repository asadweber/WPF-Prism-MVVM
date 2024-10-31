using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_notificationbatchDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
		
        Task<long> Update(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_notificationbatchEntity> listAdded, IList<tran_notificationbatchEntity> listUpdated, IList<tran_notificationbatchEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_notificationbatchEntity>> GetAll(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
		
        Task<IList<tran_notificationbatchEntity>> GetAllByPages(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDettran_notificationbatchdet(tran_notificationbatchEntity masterEntity, IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_notificationbatchEntity> GetSingle(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_notificationbatchEntity>> GAPgListView(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
