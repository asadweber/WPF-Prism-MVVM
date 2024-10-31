using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_statusDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_statusEntity gen_status, CancellationToken cancellationToken);
		
        Task<long> Update(gen_statusEntity gen_status, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_statusEntity gen_status, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_statusEntity> listAdded, IList<gen_statusEntity> listUpdated, IList<gen_statusEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_statusEntity>> GetAll(gen_statusEntity gen_status, CancellationToken cancellationToken);
		
        Task<IList<gen_statusEntity>> GetAllByPages(gen_statusEntity gen_status, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_notificationconfig(gen_statusEntity masterEntity, IList<cnf_notificationconfigEntity> listAdded, IList<cnf_notificationconfigEntity> listUpdated, IList<cnf_notificationconfigEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_applicantphases(gen_statusEntity masterEntity, IList<tran_applicantphasesEntity> listAdded, IList<tran_applicantphasesEntity> listUpdated, IList<tran_applicantphasesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_notificationbatch(gen_statusEntity masterEntity, IList<tran_notificationbatchEntity> listAdded, IList<tran_notificationbatchEntity> listUpdated, IList<tran_notificationbatchEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_statusEntity> GetSingle(gen_statusEntity gen_status, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_statusEntity>> GAPgListView(gen_statusEntity gen_status, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_statusEntity gen_status, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
