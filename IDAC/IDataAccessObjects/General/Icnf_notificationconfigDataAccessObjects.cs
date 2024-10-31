using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_notificationconfigDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_notificationconfigEntity> listAdded, IList<cnf_notificationconfigEntity> listUpdated, IList<cnf_notificationconfigEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_notificationconfigEntity>> GetAll(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
		
        Task<IList<cnf_notificationconfigEntity>> GetAllByPages(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_notificationconfigdetl(cnf_notificationconfigEntity masterEntity, IList<cnf_notificationconfigdetlEntity> listAdded, IList<cnf_notificationconfigdetlEntity> listUpdated, IList<cnf_notificationconfigdetlEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_notificationconfigEntity> GetSingle(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_notificationconfigEntity>> GAPgListView(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
