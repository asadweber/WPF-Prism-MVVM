

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_medexamresultFacadeObjects")]
    public partial interface Itran_medexamresultFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_medexamresultEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_medexamresultEntity>> GetAll(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_medexamresultEntity>> GetAllByPages(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_medexamresultEntity> GetSingle(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_medexamresultEntity>> GAPgListView(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
