using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_countryclassDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
		
        Task<long> Update(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_countryclassEntity> listAdded, IList<gen_countryclassEntity> listUpdated, IList<gen_countryclassEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_countryclassEntity>> GetAll(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
		
        Task<IList<gen_countryclassEntity>> GetAllByPages(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(gen_countryclassEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_countryclassEntity> GetSingle(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_countryclassEntity>> GAPgListView(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
