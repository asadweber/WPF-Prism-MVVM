

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_medexamnotificationFacadeObjects")]
    public partial interface Itran_medexamnotificationFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_medexamnotificationEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_medexamnotificationEntity>> GetAll(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_medexamnotificationEntity>> GetAllByPages(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_medexamnotificationEntity> GetSingle(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_medexamnotificationEntity>> GAPgListView(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
