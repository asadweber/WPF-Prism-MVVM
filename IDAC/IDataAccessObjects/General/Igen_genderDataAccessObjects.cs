using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_genderDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_genderEntity gen_gender, CancellationToken cancellationToken);
		
        Task<long> Update(gen_genderEntity gen_gender, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_genderEntity gen_gender, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_genderEntity> listAdded, IList<gen_genderEntity> listUpdated, IList<gen_genderEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_genderEntity>> GetAll(gen_genderEntity gen_gender, CancellationToken cancellationToken);
		
        Task<IList<gen_genderEntity>> GetAllByPages(gen_genderEntity gen_gender, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(gen_genderEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_genderEntity> GetSingle(gen_genderEntity gen_gender, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_genderEntity>> GAPgListView(gen_genderEntity gen_gender, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_genderEntity gen_gender, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
