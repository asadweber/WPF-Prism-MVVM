

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_bloodgroupFacadeObjects")]
    public partial interface Igen_bloodgroupFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_bloodgroupEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_bloodgroupEntity>> GetAll(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_bloodgroupEntity>> GetAllByPages(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_bloodgroupEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_bloodgroupEntity> GetSingle(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_bloodgroupEntity>> GAPgListView(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken); 
		#endregion
    
    }
}
