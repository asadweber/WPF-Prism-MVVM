using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_studentfilestorageDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
		
        Task<long> Update(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_studentfilestorageEntity> listAdded, IList<reg_studentfilestorageEntity> listUpdated, IList<reg_studentfilestorageEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_studentfilestorageEntity>> GetAll(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
		
        Task<IList<reg_studentfilestorageEntity>> GetAllByPages(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_studentfilestorageEntity> GetSingle(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_studentfilestorageEntity>> GAPgListView(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
