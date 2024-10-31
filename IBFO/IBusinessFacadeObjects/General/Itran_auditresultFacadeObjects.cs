

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_auditresultFacadeObjects")]
    public partial interface Itran_auditresultFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_auditresultEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_auditresultEntity>> GetAll(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_auditresultEntity>> GetAllByPages(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_auditresultEntity> GetSingle(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_auditresultEntity>> GAPgListView(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
