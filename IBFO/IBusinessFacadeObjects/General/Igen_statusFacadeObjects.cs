

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_statusFacadeObjects")]
    public partial interface Igen_statusFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_statusEntity gen_status, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_statusEntity gen_status, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_statusEntity gen_status, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_statusEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_statusEntity>> GetAll(gen_statusEntity gen_status, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_statusEntity>> GetAllByPages(gen_statusEntity gen_status, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetcnf_notificationconfig(gen_statusEntity Master, List<cnf_notificationconfigEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_applicantphases(gen_statusEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatch(gen_statusEntity Master, List<tran_notificationbatchEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_statusEntity> GetSingle(gen_statusEntity gen_status, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_statusEntity>> GAPgListView(gen_statusEntity gen_status, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_statusEntity gen_status, CancellationToken cancellationToken); 
		#endregion
    
    }
}
