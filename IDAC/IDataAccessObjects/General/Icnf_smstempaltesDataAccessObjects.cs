using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_smstempaltesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_smstempaltesEntity> listAdded, IList<cnf_smstempaltesEntity> listUpdated, IList<cnf_smstempaltesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_smstempaltesEntity>> GetAll(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
		
        Task<IList<cnf_smstempaltesEntity>> GetAllByPages(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_smstempaltesEntity> GetSingle(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_smstempaltesEntity>> GAPgListView(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
