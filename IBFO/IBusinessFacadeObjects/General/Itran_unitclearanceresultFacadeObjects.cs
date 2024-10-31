

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_unitclearanceresultFacadeObjects")]
    public partial interface Itran_unitclearanceresultFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_unitclearanceresultEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_unitclearanceresultEntity>> GetAll(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_unitclearanceresultEntity>> GetAllByPages(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_unitclearanceresultEntity> GetSingle(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_unitclearanceresultEntity>> GAPgListView(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
