

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_studentfilestorageFacadeObjects")]
    public partial interface Ireg_studentfilestorageFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_studentfilestorageEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_studentfilestorageEntity>> GetAll(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_studentfilestorageEntity>> GetAllByPages(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_studentfilestorageEntity> GetSingle(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_studentfilestorageEntity>> GAPgListView(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
