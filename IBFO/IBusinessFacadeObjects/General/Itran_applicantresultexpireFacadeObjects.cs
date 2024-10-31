

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_applicantresultexpireFacadeObjects")]
    public partial interface Itran_applicantresultexpireFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_applicantresultexpireEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_applicantresultexpireEntity>> GetAll(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_applicantresultexpireEntity>> GetAllByPages(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_applicantresultexpireEntity> GetSingle(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_applicantresultexpireEntity>> GAPgListView(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
