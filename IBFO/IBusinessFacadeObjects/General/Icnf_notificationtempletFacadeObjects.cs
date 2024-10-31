

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_notificationtempletFacadeObjects")]
    public partial interface Icnf_notificationtempletFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_notificationtempletEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_notificationtempletEntity>> GetAll(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_notificationtempletEntity>> GetAllByPages(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetcnf_notificationconfigdetl(cnf_notificationtempletEntity Master, List<cnf_notificationconfigdetlEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatchdet(cnf_notificationtempletEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_notificationtempletEntity> GetSingle(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_notificationtempletEntity>> GAPgListView(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken); 
		#endregion
    
    }
}
