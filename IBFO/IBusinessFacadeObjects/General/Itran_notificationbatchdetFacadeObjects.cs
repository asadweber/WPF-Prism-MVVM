

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_notificationbatchdetFacadeObjects")]
    public partial interface Itran_notificationbatchdetFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_notificationbatchdetEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_notificationbatchdetEntity>> GetAll(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_notificationbatchdetEntity>> GetAllByPages(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatchdet(tran_notificationbatchdetEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_notificationbatchdetEntity> GetSingle(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_notificationbatchdetEntity>> GAPgListView(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken); 
		#endregion
    
    }
}
