

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_servicesFacadeObjects")]
    public partial interface Igen_servicesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_servicesEntity gen_services, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_servicesEntity gen_services, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_servicesEntity gen_services, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_servicesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_servicesEntity>> GetAll(gen_servicesEntity gen_services, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_servicesEntity>> GetAllByPages(gen_servicesEntity gen_services, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_servicesEntity> GetSingle(gen_servicesEntity gen_services, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_servicesEntity>> GAPgListView(gen_servicesEntity gen_services, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
