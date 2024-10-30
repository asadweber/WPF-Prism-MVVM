

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_loginFacadeObjects")]
    public partial interface Itran_loginFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_loginEntity tran_login, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_loginEntity tran_login, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_loginEntity tran_login, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_loginEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_loginEntity>> GetAll(tran_loginEntity tran_login, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_loginEntity>> GetAllByPages(tran_loginEntity tran_login, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_loginEntity> GetSingle(tran_loginEntity tran_login, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_loginEntity>> GAPgListView(tran_loginEntity tran_login, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
