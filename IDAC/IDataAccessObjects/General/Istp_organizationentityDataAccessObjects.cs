using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Istp_organizationentityDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
		
        Task<long> Update(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
        
        Task<long> Delete(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<stp_organizationentityEntity>> GetAll(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
		
        Task<IList<stp_organizationentityEntity>> GetAllByPages(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_relativesworkinginmod(stp_organizationentityEntity masterEntity, IList<reg_relativesworkinginmodEntity> listAdded, IList<reg_relativesworkinginmodEntity> listUpdated, IList<reg_relativesworkinginmodEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetstp_organizationentity(stp_organizationentityEntity masterEntity, IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<stp_organizationentityEntity> GetSingle(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<stp_organizationentityEntity>> GAPgListView(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
