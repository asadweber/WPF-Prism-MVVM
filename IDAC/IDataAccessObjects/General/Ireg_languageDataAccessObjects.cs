using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_languageDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_languageEntity reg_language, CancellationToken cancellationToken);
		
        Task<long> Update(reg_languageEntity reg_language, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_languageEntity reg_language, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_languageEntity> listAdded, IList<reg_languageEntity> listUpdated, IList<reg_languageEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_languageEntity>> GetAll(reg_languageEntity reg_language, CancellationToken cancellationToken);
		
        Task<IList<reg_languageEntity>> GetAllByPages(reg_languageEntity reg_language, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_languageEntity> GetSingle(reg_languageEntity reg_language, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_languageEntity>> GAPgListView(reg_languageEntity reg_language, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
