

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_serviceinfoFacadeObjects")]
    public partial interface Igen_serviceinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_serviceinfoEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_serviceinfoEntity>> GetAll(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_serviceinfoEntity>> GetAllByPages(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_serviceinfoEntity> GetSingle(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_serviceinfoEntity>> GAPgListView(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
