

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_professiongroupFacadeObjects")]
    public partial interface Igen_professiongroupFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_professiongroupEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_professiongroupEntity>> GetAll(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_professiongroupEntity>> GetAllByPages(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_profession(gen_professiongroupEntity Master, List<gen_professionEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_professiongroupEntity> GetSingle(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_professiongroupEntity>> GAPgListView(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken); 
		#endregion
    
    }
}
