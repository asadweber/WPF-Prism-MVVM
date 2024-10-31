

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_applyanotherbatchFacadeObjects")]
    public partial interface Itran_applyanotherbatchFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_applyanotherbatchEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_applyanotherbatchEntity>> GetAll(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_applyanotherbatchEntity>> GetAllByPages(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_applyanotherbatchEntity> GetSingle(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_applyanotherbatchEntity>> GAPgListView(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
