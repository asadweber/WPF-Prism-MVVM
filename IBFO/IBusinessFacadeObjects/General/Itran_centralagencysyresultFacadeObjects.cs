

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_centralagencysyresultFacadeObjects")]
    public partial interface Itran_centralagencysyresultFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_centralagencysyresultEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_centralagencysyresultEntity>> GetAll(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_centralagencysyresultEntity>> GetAllByPages(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_centralagencysyresultEntity> GetSingle(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_centralagencysyresultEntity>> GAPgListView(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
