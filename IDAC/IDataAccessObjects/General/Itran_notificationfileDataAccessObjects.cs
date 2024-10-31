using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_notificationfileDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
		
        Task<long> Update(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_notificationfileEntity> listAdded, IList<tran_notificationfileEntity> listUpdated, IList<tran_notificationfileEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_notificationfileEntity>> GetAll(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
		
        Task<IList<tran_notificationfileEntity>> GetAllByPages(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_notificationfileEntity> GetSingle(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_notificationfileEntity>> GAPgListView(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion


        #region for Dropdown 
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        #endregion




    }
}
