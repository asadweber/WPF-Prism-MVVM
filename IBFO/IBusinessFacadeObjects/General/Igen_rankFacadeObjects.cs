

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_rankFacadeObjects")]
    public partial interface Igen_rankFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_rankEntity gen_rank, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_rankEntity gen_rank, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_rankEntity gen_rank, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_rankEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_rankEntity>> GetAll(gen_rankEntity gen_rank, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_rankEntity>> GetAllByPages(gen_rankEntity gen_rank, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_rankEntity> GetSingle(gen_rankEntity gen_rank, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_rankEntity>> GAPgListView(gen_rankEntity gen_rank, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
