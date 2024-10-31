

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_educationshiftFacadeObjects")]
    public partial interface Igen_educationshiftFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_educationshiftEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_educationshiftEntity>> GetAll(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_educationshiftEntity>> GetAllByPages(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_educationinfo(gen_educationshiftEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_educationshiftEntity> GetSingle(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_educationshiftEntity>> GAPgListView(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken); 
		#endregion
    
    }
}
