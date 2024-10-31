

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_servicestatusFacadeObjects")]
    public partial interface Igen_servicestatusFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_servicestatusEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_servicestatusEntity>> GetAll(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_servicestatusEntity>> GetAllByPages(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_servicestatusEntity> GetSingle(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_servicestatusEntity>> GAPgListView(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
