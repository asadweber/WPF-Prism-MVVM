

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_imagegallaryFacadeObjects")]
    public partial interface Igen_imagegallaryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_imagegallaryEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_imagegallaryEntity>> GetAll(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_imagegallaryEntity>> GetAllByPages(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_imagegallaryEntity> GetSingle(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_imagegallaryEntity>> GAPgListView(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
