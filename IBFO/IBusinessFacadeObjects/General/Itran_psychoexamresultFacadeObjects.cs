

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_psychoexamresultFacadeObjects")]
    public partial interface Itran_psychoexamresultFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_psychoexamresultEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_psychoexamresultEntity>> GetAll(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_psychoexamresultEntity>> GetAllByPages(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_psychoexamresultEntity> GetSingle(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_psychoexamresultEntity>> GAPgListView(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
