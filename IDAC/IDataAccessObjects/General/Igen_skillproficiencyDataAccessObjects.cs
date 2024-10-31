using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_skillproficiencyDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
		
        Task<long> Update(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_skillproficiencyEntity> listAdded, IList<gen_skillproficiencyEntity> listUpdated, IList<gen_skillproficiencyEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_skillproficiencyEntity>> GetAll(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
		
        Task<IList<gen_skillproficiencyEntity>> GetAllByPages(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_language(gen_skillproficiencyEntity masterEntity, IList<reg_languageEntity> listAdded, IList<reg_languageEntity> listUpdated, IList<reg_languageEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_skillproficiencyEntity> GetSingle(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_skillproficiencyEntity>> GAPgListView(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
