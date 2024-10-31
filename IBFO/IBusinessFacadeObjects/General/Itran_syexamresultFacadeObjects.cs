

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_syexamresultFacadeObjects")]
    public partial interface Itran_syexamresultFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_syexamresultEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_syexamresultEntity>> GetAll(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_syexamresultEntity>> GetAllByPages(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_syexamresultEntity> GetSingle(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_syexamresultEntity>> GAPgListView(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
