using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_studentmenuskipdetailDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_studentmenuskipdetailEntity> listAdded, IList<cnf_studentmenuskipdetailEntity> listUpdated, IList<cnf_studentmenuskipdetailEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_studentmenuskipdetailEntity>> GetAll(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
		
        Task<IList<cnf_studentmenuskipdetailEntity>> GetAllByPages(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_studentmenuskipdetailEntity> GetSingle(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_studentmenuskipdetailEntity>> GAPgListView(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
