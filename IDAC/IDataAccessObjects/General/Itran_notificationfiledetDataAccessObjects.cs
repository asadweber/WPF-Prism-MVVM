using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_notificationfiledetDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
		
        Task<long> Update(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_notificationfiledetEntity> listAdded, IList<tran_notificationfiledetEntity> listUpdated, IList<tran_notificationfiledetEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_notificationfiledetEntity>> GetAll(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
		
        Task<IList<tran_notificationfiledetEntity>> GetAllByPages(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_notificationfiledetEntity> GetSingle(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_notificationfiledetEntity>> GAPgListView(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        #endregion





    }
}
