

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_educationmajorFacadeObjects")]
    public partial interface Igen_educationmajorFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_educationmajorEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_educationmajorEntity>> GetAll(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_educationmajorEntity>> GetAllByPages(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_educationinfo(gen_educationmajorEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_educationmajorEntity> GetSingle(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_educationmajorEntity>> GAPgListView(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken); 
		#endregion
    
    }
}
