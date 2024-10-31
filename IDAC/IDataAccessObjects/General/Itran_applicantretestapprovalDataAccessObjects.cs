using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_applicantretestapprovalDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
		
        Task<long> Update(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_applicantretestapprovalEntity> listAdded, IList<tran_applicantretestapprovalEntity> listUpdated, IList<tran_applicantretestapprovalEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_applicantretestapprovalEntity>> GetAll(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
		
        Task<IList<tran_applicantretestapprovalEntity>> GetAllByPages(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_applicantretestapprovalEntity> GetSingle(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_applicantretestapprovalEntity>> GAPgListView(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
