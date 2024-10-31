

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_syexamnotificationFacadeObjects")]
    public partial interface Itran_syexamnotificationFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_syexamnotificationEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_syexamnotificationEntity>> GetAll(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_syexamnotificationEntity>> GetAllByPages(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_syexamnotificationEntity> GetSingle(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_syexamnotificationEntity>> GAPgListView(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
