

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_imagegallarycategoryFacadeObjects")]
    public partial interface Igen_imagegallarycategoryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_imagegallarycategoryEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_imagegallarycategoryEntity>> GetAll(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_imagegallarycategoryEntity>> GetAllByPages(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_imagegallary(gen_imagegallarycategoryEntity Master, List<gen_imagegallaryEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_imagegallarycategoryEntity> GetSingle(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_imagegallarycategoryEntity>> GAPgListView(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken); 
		#endregion
    
    }
}
