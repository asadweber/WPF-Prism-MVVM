

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_generallookFacadeObjects")]
    public partial interface Igen_generallookFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_generallookEntity gen_generallook, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_generallookEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_generallookEntity>> GetAll(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_generallookEntity>> GetAllByPages(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_generallookEntity> GetSingle(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_generallookEntity>> GAPgListView(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
