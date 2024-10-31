

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_trainingjoinFacadeObjects")]
    public partial interface Itran_trainingjoinFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_trainingjoinEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_trainingjoinEntity>> GetAll(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_trainingjoinEntity>> GetAllByPages(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_trainingjoinEntity> GetSingle(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_trainingjoinEntity>> GAPgListView(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
