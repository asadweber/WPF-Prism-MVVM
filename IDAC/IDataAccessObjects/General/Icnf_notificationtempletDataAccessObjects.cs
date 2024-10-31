using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_notificationtempletDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_notificationtempletEntity> listAdded, IList<cnf_notificationtempletEntity> listUpdated, IList<cnf_notificationtempletEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_notificationtempletEntity>> GetAll(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
		
        Task<IList<cnf_notificationtempletEntity>> GetAllByPages(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_notificationconfigdetl(cnf_notificationtempletEntity masterEntity, IList<cnf_notificationconfigdetlEntity> listAdded, IList<cnf_notificationconfigdetlEntity> listUpdated, IList<cnf_notificationconfigdetlEntity> listDeleted, CancellationToken cancellationToken);

       
        Task<long> SaveMasterDettran_notificationbatchdet(cnf_notificationtempletEntity masterEntity, IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_notificationtempletEntity> GetSingle(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_notificationtempletEntity>> GAPgListView(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
