

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_notificationconfigFacadeObjects")]
    public partial interface Icnf_notificationconfigFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_notificationconfigEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_notificationconfigEntity>> GetAll(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_notificationconfigEntity>> GetAllByPages(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetcnf_notificationconfigdetl(cnf_notificationconfigEntity Master, List<cnf_notificationconfigdetlEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_notificationconfigEntity> GetSingle(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_notificationconfigEntity>> GAPgListView(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken); 
		#endregion
    
    }
}
