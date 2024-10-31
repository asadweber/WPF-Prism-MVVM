using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_countryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_countryEntity gen_country, CancellationToken cancellationToken);
		
        Task<long> Update(gen_countryEntity gen_country, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_countryEntity gen_country, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_countryEntity> listAdded, IList<gen_countryEntity> listUpdated, IList<gen_countryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_countryEntity>> GetAll(gen_countryEntity gen_country, CancellationToken cancellationToken);
		
        Task<IList<gen_countryEntity>> GetAllByPages(gen_countryEntity gen_country, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_countrycity(gen_countryEntity masterEntity, IList<gen_countrycityEntity> listAdded, IList<gen_countrycityEntity> listUpdated, IList<gen_countrycityEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_countryclass(gen_countryEntity masterEntity, IList<gen_countryclassEntity> listAdded, IList<gen_countryclassEntity> listUpdated, IList<gen_countryclassEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_instituteinfo(gen_countryEntity masterEntity, IList<gen_instituteinfoEntity> listAdded, IList<gen_instituteinfoEntity> listUpdated, IList<gen_instituteinfoEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_educationinfo(gen_countryEntity masterEntity, IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_familly(gen_countryEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_countryEntity> GetSingle(gen_countryEntity gen_country, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_countryEntity>> GAPgListView(gen_countryEntity gen_country, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
