

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_finalexamresultFacadeObjects")]
    public partial interface Itran_finalexamresultFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_finalexamresultEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_finalexamresultEntity>> GetAll(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_finalexamresultEntity>> GetAllByPages(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_finalexamresultEntity> GetSingle(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_finalexamresultEntity>> GAPgListView(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
