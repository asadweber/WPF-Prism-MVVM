using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_languagesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
		
        Task<long> Update(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_languagesEntity> listAdded, IList<gen_languagesEntity> listUpdated, IList<gen_languagesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_languagesEntity>> GetAll(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
		
        Task<IList<gen_languagesEntity>> GetAllByPages(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_language(gen_languagesEntity masterEntity, IList<reg_languageEntity> listAdded, IList<reg_languageEntity> listUpdated, IList<reg_languageEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_languagesEntity> GetSingle(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_languagesEntity>> GAPgListView(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_languagesEntity gen_languages, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
