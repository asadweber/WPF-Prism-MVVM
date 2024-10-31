

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_famillyFacadeObjects")]
    public partial interface Ireg_famillyFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_famillyEntity reg_familly, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_famillyEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_famillyEntity>> GetAll(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_famillyEntity>> GetAllByPages(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(reg_famillyEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_nonkuwaitystatus(reg_famillyEntity Master, List<reg_nonkuwaitystatusEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_famillyEntity> GetSingle(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_famillyEntity>> GAPgListView(reg_famillyEntity reg_familly, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_famillyEntity reg_familly, CancellationToken cancellationToken); 
		#endregion
    
    }
}
