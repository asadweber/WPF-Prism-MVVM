using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_emergencycontactinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
		
        Task<long> Update(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_emergencycontactinfoEntity> listAdded, IList<reg_emergencycontactinfoEntity> listUpdated, IList<reg_emergencycontactinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_emergencycontactinfoEntity>> GetAll(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
		
        Task<IList<reg_emergencycontactinfoEntity>> GetAllByPages(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_relativesworkinginmod(reg_emergencycontactinfoEntity masterEntity, IList<reg_relativesworkinginmodEntity> listAdded, IList<reg_relativesworkinginmodEntity> listUpdated, IList<reg_relativesworkinginmodEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_emergencycontactinfoEntity> GetSingle(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_emergencycontactinfoEntity>> GAPgListView(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
