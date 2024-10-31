using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_notificationconfigdetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_notificationconfigdetlEntity> listAdded, IList<cnf_notificationconfigdetlEntity> listUpdated, IList<cnf_notificationconfigdetlEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_notificationconfigdetlEntity>> GetAll(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
		
        Task<IList<cnf_notificationconfigdetlEntity>> GetAllByPages(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_notificationconfigdetlEntity> GetSingle(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_notificationconfigdetlEntity>> GAPgListView(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
