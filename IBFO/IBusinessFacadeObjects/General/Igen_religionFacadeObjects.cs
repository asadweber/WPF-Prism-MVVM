

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_religionFacadeObjects")]
    public partial interface Igen_religionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_religionEntity gen_religion, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_religionEntity gen_religion, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_religionEntity gen_religion, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_religionEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_religionEntity>> GetAll(gen_religionEntity gen_religion, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_religionEntity>> GetAllByPages(gen_religionEntity gen_religion, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_religionEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_religionEntity> GetSingle(gen_religionEntity gen_religion, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_religionEntity>> GAPgListView(gen_religionEntity gen_religion, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken); 
		#endregion
    
    }
}
