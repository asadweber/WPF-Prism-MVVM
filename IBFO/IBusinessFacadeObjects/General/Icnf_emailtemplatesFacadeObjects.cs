

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_emailtemplatesFacadeObjects")]
    public partial interface Icnf_emailtemplatesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_emailtemplatesEntity cnf_emailtemplates, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_emailtemplatesEntity cnf_emailtemplates, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_emailtemplatesEntity cnf_emailtemplates, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_emailtemplatesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_emailtemplatesEntity>> GetAll(cnf_emailtemplatesEntity cnf_emailtemplates, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_emailtemplatesEntity>> GetAllByPages(cnf_emailtemplatesEntity cnf_emailtemplates, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_emailtemplatesEntity> GetSingle(cnf_emailtemplatesEntity cnf_emailtemplates, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_emailtemplatesEntity>> GAPgListView(cnf_emailtemplatesEntity cnf_emailtemplates, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
