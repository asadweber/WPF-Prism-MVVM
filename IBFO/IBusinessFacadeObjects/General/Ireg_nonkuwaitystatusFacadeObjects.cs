

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_nonkuwaitystatusFacadeObjects")]
    public partial interface Ireg_nonkuwaitystatusFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_nonkuwaitystatusEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_nonkuwaitystatusEntity>> GetAll(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_nonkuwaitystatusEntity>> GetAllByPages(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_nonkuwaitystatusEntity> GetSingle(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_nonkuwaitystatusEntity>> GAPgListView(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
