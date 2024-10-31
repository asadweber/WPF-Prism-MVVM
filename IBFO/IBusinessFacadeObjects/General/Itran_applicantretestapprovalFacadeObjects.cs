

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_applicantretestapprovalFacadeObjects")]
    public partial interface Itran_applicantretestapprovalFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_applicantretestapprovalEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_applicantretestapprovalEntity>> GetAll(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_applicantretestapprovalEntity>> GetAllByPages(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_applicantretestapprovalEntity> GetSingle(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_applicantretestapprovalEntity>> GAPgListView(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
