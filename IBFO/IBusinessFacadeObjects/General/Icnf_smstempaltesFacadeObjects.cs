

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_smstempaltesFacadeObjects")]
    public partial interface Icnf_smstempaltesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_smstempaltesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_smstempaltesEntity>> GetAll(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_smstempaltesEntity>> GetAllByPages(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_smstempaltesEntity> GetSingle(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_smstempaltesEntity>> GAPgListView(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
