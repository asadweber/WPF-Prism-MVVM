

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_notificationbatchFacadeObjects")]
    public partial interface Itran_notificationbatchFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_notificationbatchEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_notificationbatchEntity>> GetAll(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_notificationbatchEntity>> GetAllByPages(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatchdet(tran_notificationbatchEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_notificationbatchEntity> GetSingle(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_notificationbatchEntity>> GAPgListView(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken); 
		#endregion
    
    }
}
