

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_educationgradeFacadeObjects")]
    public partial interface Igen_educationgradeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_educationgradeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_educationgradeEntity>> GetAll(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_educationgradeEntity>> GetAllByPages(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_educationinfo(gen_educationgradeEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_educationgradeEntity> GetSingle(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_educationgradeEntity>> GAPgListView(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken); 
		#endregion
    
    }
}
