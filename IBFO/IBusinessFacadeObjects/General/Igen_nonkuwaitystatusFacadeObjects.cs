

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_nonkuwaitystatusFacadeObjects")]
    public partial interface Igen_nonkuwaitystatusFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_nonkuwaitystatusEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_nonkuwaitystatusEntity>> GetAll(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_nonkuwaitystatusEntity>> GetAllByPages(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_nonkuwaitystatus(gen_nonkuwaitystatusEntity Master, List<reg_nonkuwaitystatusEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_nonkuwaitystatusEntity> GetSingle(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_nonkuwaitystatusEntity>> GAPgListView(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken); 
		#endregion
    
    }
}
