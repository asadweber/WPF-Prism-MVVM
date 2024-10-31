

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_notificationconfigdetlFacadeObjects")]
    public partial interface Icnf_notificationconfigdetlFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_notificationconfigdetlEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_notificationconfigdetlEntity>> GetAll(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_notificationconfigdetlEntity>> GetAllByPages(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_notificationconfigdetlEntity> GetSingle(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_notificationconfigdetlEntity>> GAPgListView(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
