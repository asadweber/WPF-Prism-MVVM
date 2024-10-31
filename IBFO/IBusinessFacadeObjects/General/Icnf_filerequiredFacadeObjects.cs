

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_filerequiredFacadeObjects")]
    public partial interface Icnf_filerequiredFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_filerequiredEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_filerequiredEntity>> GetAll(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_filerequiredEntity>> GetAllByPages(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandidatereqfile(cnf_filerequiredEntity Master, List<gen_batchcandidatereqfileEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_studentfilestorage(cnf_filerequiredEntity Master, List<reg_studentfilestorageEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_filerequiredEntity> GetSingle(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_filerequiredEntity>> GAPgListView(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken); 
		#endregion
    
    }
}
