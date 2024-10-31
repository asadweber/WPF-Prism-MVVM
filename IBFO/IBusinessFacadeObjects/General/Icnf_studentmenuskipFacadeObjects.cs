

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_studentmenuskipFacadeObjects")]
    public partial interface Icnf_studentmenuskipFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_studentmenuskipEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_studentmenuskipEntity>> GetAll(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_studentmenuskipEntity>> GetAllByPages(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetcnf_studentmenuskipdetail(cnf_studentmenuskipEntity Master, List<cnf_studentmenuskipdetailEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_studentmenuskipEntity> GetSingle(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_studentmenuskipEntity>> GAPgListView(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken); 
		#endregion
    
    }
}
