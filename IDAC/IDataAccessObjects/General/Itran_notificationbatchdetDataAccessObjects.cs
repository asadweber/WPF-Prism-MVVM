using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_notificationbatchdetDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
		
        Task<long> Update(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_notificationbatchdetEntity>> GetAll(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
		
        Task<IList<tran_notificationbatchdetEntity>> GetAllByPages(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDettran_notificationbatchdet(tran_notificationbatchdetEntity masterEntity, IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_notificationbatchdetEntity> GetSingle(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_notificationbatchdetEntity>> GAPgListView(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
