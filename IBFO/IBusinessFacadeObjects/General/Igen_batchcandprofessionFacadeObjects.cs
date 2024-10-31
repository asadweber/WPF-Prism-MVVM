

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_batchcandprofessionFacadeObjects")]
    public partial interface Igen_batchcandprofessionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_batchcandprofessionEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_batchcandprofessionEntity>> GetAll(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_batchcandprofessionEntity>> GetAllByPages(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_batchcandprofessionEntity> GetSingle(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_batchcandprofessionEntity>> GAPgListView(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
