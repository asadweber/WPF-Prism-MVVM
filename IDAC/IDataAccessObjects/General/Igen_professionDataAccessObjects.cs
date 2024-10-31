using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_professionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_professionEntity gen_profession, CancellationToken cancellationToken);
		
        Task<long> Update(gen_professionEntity gen_profession, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_professionEntity gen_profession, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_professionEntity> listAdded, IList<gen_professionEntity> listUpdated, IList<gen_professionEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_professionEntity>> GetAll(gen_professionEntity gen_profession, CancellationToken cancellationToken);
		
        Task<IList<gen_professionEntity>> GetAllByPages(gen_professionEntity gen_profession, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_batchcandprofession(gen_professionEntity masterEntity, IList<gen_batchcandprofessionEntity> listAdded, IList<gen_batchcandprofessionEntity> listUpdated, IList<gen_batchcandprofessionEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_registrationinfo(gen_professionEntity masterEntity, IList<reg_registrationinfoEntity> listAdded, IList<reg_registrationinfoEntity> listUpdated, IList<reg_registrationinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_professionEntity> GetSingle(gen_professionEntity gen_profession, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_professionEntity>> GAPgListView(gen_professionEntity gen_profession, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
